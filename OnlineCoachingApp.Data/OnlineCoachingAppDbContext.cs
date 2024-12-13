using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineCoachingApp.Data.Models;

namespace OnlineCoachingApp.Web.Data
{
    public class OnlineCoachingAppDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public OnlineCoachingAppDbContext(DbContextOptions<OnlineCoachingAppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<TrainingProgram> TrainingPrograms { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(OnlineCoachingAppDbContext)) ??
                                      Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }
    }
}