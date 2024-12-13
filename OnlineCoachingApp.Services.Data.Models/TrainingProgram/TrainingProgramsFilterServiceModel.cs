using OnlineCoachingApp.Web.ViewModels.TrainingProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingApp.Services.Data.Models.TrainingProgram
{
    public class TrainingProgramsFilterServiceModel
    {
        public TrainingProgramsFilterServiceModel()
        {
            this.TrainingPrograms = new HashSet<TrainingProgramAllViewModel>();
        }

        //public int TotalTrainingProgramsCount { get; set; }

        public IEnumerable<TrainingProgramAllViewModel> TrainingPrograms { get; set; }
    }
}
