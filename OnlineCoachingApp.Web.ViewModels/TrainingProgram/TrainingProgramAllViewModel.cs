using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineCoachingApp.Web.ViewModels.TrainingProgram
{
    public class TrainingProgramAllViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
