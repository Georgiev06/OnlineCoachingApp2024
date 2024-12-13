using OnlineCoachingApp.Web.ViewModels.TrainingProgram.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingApp.Web.ViewModels.TrainingProgram
{
    public class TrainingProgramQueryModel
    {
        public TrainingProgramQueryModel()
        {
            //this.CurrentPage = 1;
            //this.TrainingProgramsPerPage = 6;
            this.Categories = new HashSet<string>();
            this.TrainingPrograms = new HashSet<TrainingProgramAllViewModel>();
        }

        public string? Category { get; set; }

        [Display(Name = "Search here...")]
        public string? SearchTerm { get; set; }

        [Display(Name = "Sort by")]
        public TrainingProgramSorting TrainingProgramSorting { get; set; }

        //public int CurrentPage { get; set; } 

        ////public int TrainingProgramsPerPage { get; set; }

        //public int TotalTrainingProgramsCount { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public IEnumerable<TrainingProgramAllViewModel> TrainingPrograms { get; set; }
    }
}
