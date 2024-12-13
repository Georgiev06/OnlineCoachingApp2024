using System;
using System.ComponentModel.DataAnnotations;
using static OnlineCoachingApp.Common.EntityValidationsConstants.Category;

namespace OnlineCoachingApp.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<TrainingProgram> TrainingPrograms { get; set; } = new HashSet<TrainingProgram>();
    }
}
