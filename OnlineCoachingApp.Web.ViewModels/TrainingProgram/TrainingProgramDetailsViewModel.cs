using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingApp.Web.ViewModels.TrainingProgram
{
    public class TrainingProgramDetailsViewModel : TrainingProgramAllViewModel
    {
        public string Description { get; set; } = null!;

        public int DurationInWeeks { get; set; }

        public string Category { get; set; } = null!;
    }
}
