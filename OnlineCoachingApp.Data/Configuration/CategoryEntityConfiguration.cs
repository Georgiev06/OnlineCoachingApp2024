using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineCoachingApp.Data.Models;

namespace OnlineCoachingApp.Data.Configuration
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(this.SeedCategories());
        }

        private Category[] SeedCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category()
            {
                Id = 1,
                Name = "Outdoor Fitness"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Fitness Program"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Home Workouts"
            };

            categories.Add(category);

            return categories.ToArray();
        }
    }
}
