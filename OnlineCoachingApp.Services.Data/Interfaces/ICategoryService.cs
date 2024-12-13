using OnlineCoachingApp.Web.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingApp.Services.Data.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryViewModel>> GetAllCategories();
        Task<bool> GetCategoryById(int id);
        Task<IEnumerable<string>> GetAllCategoryNames();
    }
}
