using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineCoachingApp.Services.Data.Interfaces;
using OnlineCoachingApp.Services.Data.Models.TrainingProgram;
using OnlineCoachingApp.Web.Infrastructure.Extensions;
using OnlineCoachingApp.Web.ViewModels.TrainingProgram;
using static OnlineCoachingApp.Common.NotificationMessagesConstants;

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
        public async Task<IActionResult> All([FromQuery] TrainingProgramQueryModel queryModel)
        {
            try
            {
                TrainingProgramsFilterServiceModel serviceModel = await this._trainingProgramService.AllAsync(queryModel);

                queryModel.TrainingPrograms = serviceModel.TrainingPrograms;
                queryModel.Categories = await this._categoryService.GetAllCategoryNames();

                return this.View(queryModel);
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "An error occurred while retrieving the training programs. Please try again later.";

                return this.RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            try
            {
                TrainingProgramViewModel trainingProgramViewModel = new TrainingProgramViewModel()
                {
                    Categories = await this._categoryService.GetAllCategories()
                };

                return this.View(trainingProgramViewModel);
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "We encountered an issue while processing your request. Please try again later.";

                return this.RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Add(TrainingProgramViewModel model)
        {
            bool categoryExists = await this._categoryService.GetCategoryById(model.CategoryId);

            if (!categoryExists)
            {
                this.TempData[ErrorMessage] = "The selected category does not exist. Please choose a valid category.";
            }

            if (!this.ModelState.IsValid)
            {
                model.Categories = await this._categoryService.GetAllCategories();

                return this.View(model);
            }

            try
            {
                await this._trainingProgramService.AddAsync(model);

            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "Something went wrong while adding the training program. Please try again or contact support.";

                model.Categories = await this._categoryService.GetAllCategories();

                return this.View(model);
            }

            return this.RedirectToAction("All", "TrainingProgram");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            bool trainingProgramExists = await this._trainingProgramService.ExistsByIdAsync(id);

            if (!trainingProgramExists)
            {
                this.TempData[ErrorMessage] = "The training program you are looking for does not exist or may have been removed.";

                return this.RedirectToAction("All", "TrainingProgram");
            }

            try
            {
                TrainingProgramDetailsViewModel viewModel = await this._trainingProgramService.DetailsAsync(id);

                return View(viewModel);
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "We encountered an unexpected issue while retrieving the program details. Please contact support if the issue persists.";

                return this.RedirectToAction("All", "TrainingProgram");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            bool trainingProgramExists = await this._trainingProgramService.ExistsByIdAsync(id);

            if (!trainingProgramExists)
            {
                this.TempData[ErrorMessage] = "The training program with the specified ID does not exist.";

                return this.RedirectToAction("All", "TrainingProgram");
            }

            try
            {
                TrainingProgramViewModel viewModel = await this._trainingProgramService.EditAsync(id);

                viewModel.Categories = await this._categoryService.GetAllCategories();

                return this.View(viewModel);
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "An unexpected error occurred while trying to load the training program. Please try again later.";

                return this.RedirectToAction("All", "TrainingProgram");
            }

            //Check if current user has role admin!

        }

        [HttpPost]
        public async Task<IActionResult> Edit(TrainingProgramViewModel model, string id)
        {
            if (!this.ModelState.IsValid)
            {
                model.Categories = await this._categoryService.GetAllCategories();

                return View(model);
            }

            bool trainingProgramExists = await this._trainingProgramService.ExistsByIdAsync(id);

            if (!trainingProgramExists)
            {
                this.TempData[ErrorMessage] = "The training program with the specified ID does not exist.";
                return this.RedirectToAction("All", "TrainingProgram");
            }

            try
            {
                await this._trainingProgramService.EditByIdAsync(model, id);
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "An unexpected error occurred while trying to load the training program. Please try again later.";
                model.Categories = await this._categoryService.GetAllCategories();

                return this.View(model);
            }

            return this.RedirectToAction("Details", "TrainingProgram", new { id });
        }

    }
}
