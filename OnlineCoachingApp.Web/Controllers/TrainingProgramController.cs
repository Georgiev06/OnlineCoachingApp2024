using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using OnlineCoachingApp.Services.Data.Interfaces;
using OnlineCoachingApp.Services.Data.Models.TrainingProgram;
using OnlineCoachingApp.Web.Infrastructure.Extensions;
using OnlineCoachingApp.Web.ViewModels.TrainingProgram;

namespace OnlineCoachingApp.Web.Controllers
{
    [Authorize]
    public class TrainingProgramController : Controller
    {
        private readonly ICategoryService _categoryService;

        private readonly ITrainingProgramService _trainingProgramService;

        public TrainingProgramController(ICategoryService categoryService, ITrainingProgramService trainingProgramService)
        {
            this._categoryService = categoryService;
            this._trainingProgramService = trainingProgramService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]TrainingProgramQueryModel queryModel)
        {
            TrainingProgramsFilterServiceModel serviceModel = await this._trainingProgramService.All(queryModel);

            queryModel.TrainingPrograms = serviceModel.TrainingPrograms;
            queryModel.Categories = await this._categoryService.GetAllCategoryNames();

            return this.View(queryModel);
        }

        [HttpGet]
        public async Task<IActionResult> Add() 
        {
            //bool isCoach = await this._coachService.GetCoachByUserId(this.User.GetUserId()!);
                
            TrainingProgramViewModel trainingProgramViewModel = new TrainingProgramViewModel()
            {
                Categories = await this._categoryService.GetAllCategories()
            };

            return this.View(trainingProgramViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TrainingProgramViewModel model)
        {
            bool categoryExists = await this._categoryService.GetCategoryById(model.CategoryId);

            if (!categoryExists) 
            {
                this.ModelState.AddModelError(nameof(model.CategoryId), "Selected category does not exists!");
            }

            if (!this.ModelState.IsValid) 
            { 
                model.Categories = await this._categoryService.GetAllCategories();

                return this.View(model);
            }

            try
            {
                await this._trainingProgramService.Add(model);
            }
            catch (Exception _)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add your new Training program! Please try again later!");
                model.Categories = await this._categoryService.GetAllCategories();

                return this.View(model);
            }

            return this.RedirectToAction("Index", "Home");

        }
    }
}
