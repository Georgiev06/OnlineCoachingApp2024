using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineCoachingApp.Data.Models;
using OnlineCoachingApp.Services.Data.Interfaces;
using OnlineCoachingApp.Services.Data.Models.TrainingProgram;
using OnlineCoachingApp.Web.Data;
using OnlineCoachingApp.Web.ViewModels.Home;
using OnlineCoachingApp.Web.ViewModels.TrainingProgram;
using OnlineCoachingApp.Web.ViewModels.TrainingProgram.Enums;

namespace OnlineCoachingApp.Services.Data
{
    public class TrainingProgramService : ITrainingProgramService
    {
        private readonly OnlineCoachingAppDbContext _data;

        public TrainingProgramService(OnlineCoachingAppDbContext data)
        {
            this._data = data;
        }

        public async Task Add(TrainingProgramViewModel model)
        {
            TrainingProgram trainingProgram = new TrainingProgram()
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                DurationInWeeks = model.DurationInWeeks,
                Price = model.Price,
                CategoryId = model.CategoryId
            };

            await this._data.AddAsync(trainingProgram);

            await this._data.SaveChangesAsync();
        }

        public async Task<TrainingProgramsFilterServiceModel> All(TrainingProgramQueryModel queryModel)
        {
            IQueryable<TrainingProgram> trainingProgramsQuery = this._data
                .TrainingPrograms
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.Category))
            {
                trainingProgramsQuery = trainingProgramsQuery
                    .Where(tp => tp.Category.Name == queryModel.Category);
            }

            if (!string.IsNullOrWhiteSpace(queryModel.SearchTerm))
            {
                string wildCard = $"%{queryModel.SearchTerm.ToLower()}%";

                trainingProgramsQuery = trainingProgramsQuery
                    .Where(tp => EF.Functions.Like(tp.Name, wildCard) ||
                                 EF.Functions.Like(tp.Description, wildCard) || 
                                 EF.Functions.Like(tp.DurationInWeeks.ToString(), wildCard));
            }

            trainingProgramsQuery = queryModel.TrainingProgramSorting switch
            {
                TrainingProgramSorting.Newest => trainingProgramsQuery.OrderByDescending(tp => tp.CreatedOn),
                TrainingProgramSorting.Oldest => trainingProgramsQuery.OrderBy(tp => tp.CreatedOn),
                TrainingProgramSorting.PriceAscending => trainingProgramsQuery.OrderBy(tp => tp.Price),
                TrainingProgramSorting.PriceDescending => trainingProgramsQuery.OrderByDescending(tp => tp.Price),
                _ => trainingProgramsQuery.OrderByDescending(tp => tp.CreatedOn)
            };

            IEnumerable<TrainingProgramAllViewModel> allTrainingPrograms = await trainingProgramsQuery
                .Where(tp => tp.IsActive)
                .Select(tp => new TrainingProgramAllViewModel 
                { 
                    Id = tp.Id.ToString(),
                    Name = tp.Name,
                    ImageUrl = tp.ImageUrl,
                    Price = tp.Price
                }).ToArrayAsync();

            return new TrainingProgramsFilterServiceModel()
            {
                TrainingPrograms = allTrainingPrograms,
            };
        }

        public async Task<IEnumerable<IndexViewModel>> LatestTrainingPrograms()
        {
            IEnumerable<IndexViewModel> latestPrograms = await this._data.TrainingPrograms
                .Where(tp => tp.IsActive)
                .OrderByDescending(tp => tp.CreatedOn)
                .Take(5)
                .Select(tp => new IndexViewModel
                {
                    Id = tp.Id.ToString(),
                    Name = tp.Name,
                    ImageUrl = tp.ImageUrl,
                    Price = tp.Price
                })
                .ToListAsync();

            return latestPrograms;
        }
    }
}
