using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
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
            IEnumerable<IndexViewModel> viewModel = await this._trainingProgramService.LatestTrainingPrograms();
            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}