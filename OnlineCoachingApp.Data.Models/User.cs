using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineCoachingApp.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            this.Id = Guid.NewGuid();
        }
        public virtual ICollection<TrainingProgram> TrainingPrograms { get; set; } = new HashSet<TrainingProgram>();
    }
}
