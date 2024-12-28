 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using static OnlineCoachingApp.Common.EntityValidationsConstants.User;

namespace OnlineCoachingApp.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            this.Id = Guid.NewGuid();

            this.TrainingPrograms = new HashSet<TrainingProgram>();
        }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public virtual ICollection<TrainingProgram> TrainingPrograms { get; set; } = new HashSet<TrainingProgram>();
    }
}
