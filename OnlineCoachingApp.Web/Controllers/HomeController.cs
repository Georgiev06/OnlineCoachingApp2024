using Microsoft.AspNetCore.Mvc;
using OnlineCoachingApp.Services.Data.Interfaces;
using OnlineCoachingApp.Web.ViewModels.Home;

namespace OnlineCoachingApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITrainingProgramService _trainingProgramService;
        public HomeController(ITrainingProgramService trainingProgramService)
        {
            this._trainingProgramService = trainingProgramService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<IndexViewModel> viewModel = await this._trainingProgramService.LatestTrainingProgramsAsync();
            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404) 
            {
                return this.View("Error404");
            }

            return this.View(); 
        } 
    }
}