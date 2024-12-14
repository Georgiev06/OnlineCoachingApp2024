using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCoachingApp.Services.Data.Models.TrainingProgram;
using OnlineCoachingApp.Web.ViewModels.Home;
using OnlineCoachingApp.Web.ViewModels.TrainingProgram;

namespace OnlineCoachingApp.Services.Data.Interfaces
{
    public interface ITrainingProgramService
    {
        Task<IEnumerable<IndexViewModel>> LatestTrainingProgramsAsync();

        Task AddAsync(TrainingProgramViewModel model);

        Task<TrainingProgramsFilterServiceModel> AllAsync(TrainingProgramQueryModel queryModel);

        Task<TrainingProgramDetailsViewModel> DetailsAsync(string trainingProgramId);

        Task<bool> ExistsByIdAsync(string trainingProgramId);

        Task<TrainingProgramViewModel> EditAsync(string trainingProgramId);

        Task EditByIdAsync (TrainingProgramViewModel model, string trainingProgramId);

    }
}
