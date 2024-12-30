using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OnlineCoachingApp.Data.Models;
using OnlineCoachingApp.Web.ViewModels.User;

namespace OnlineCoachingApp.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;

        public UserController(
            UserManager<User> userManager,
            IUserStore<User> userStore,
            SignInManager<User> signInManager)
        {
            this._userManager = userManager;
            this._userStore = userStore;
            this._signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) 
            {
                return this.View(model);
            }

            User user = new User() 
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
            };

            await this._userManager.SetEmailAsync(user, model.Email);

            await this._userManager.SetUserNameAsync(user, model.Email);

            IdentityResult result = 
                await this._userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded) 
            {
                foreach (IdentityError error in result.Errors)
                {
                    this.ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }

            await this._signInManager.SignInAsync(user, isPersistent: false);

            return this.RedirectToAction("Index", "Home");

        }
    }
}
