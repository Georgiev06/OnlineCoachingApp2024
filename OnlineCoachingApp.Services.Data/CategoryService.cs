using Microsoft.EntityFrameworkCore;
using OnlineCoachingApp.Services.Data.Interfaces;
using OnlineCoachingApp.Web.Data;
using OnlineCoachingApp.Web.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingApp.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly OnlineCoachingAppDbContext _data;

        public CategoryService(OnlineCoachingAppDbContext data)
        {
            this._data = data;
        }

        public async Task<IEnumerable<CategoryViewModel>> GetAllCategories()
        {
            IEnumerable<CategoryViewModel> categories = await this._data.Categories
                .AsNoTracking()
                .Select(c => new CategoryViewModel() 
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToArrayAsync();


            return categories;
        }

        public async Task<IEnumerable<string>> GetAllCategoryNames()
        {
            IEnumerable<string> allCategoryNames = await this._data.Categories
                .Select(c => c.Name)
                .Distinct()
                .ToArrayAsync();

            return allCategoryNames;
        }

        public async Task<bool> GetCategoryById(int id)
        {
            bool result = await this._data.Categories.AnyAsync(c => c.Id == id);

            return result;
        }
    }
}
