using Andreys.Services;
using Andreys.ViewModels.Users;
using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andreys.Controllers
{
    public class UsersController : Controller
    {
        private IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public HttpResponse Login()
        {
            return this.View();
        }

        [HttpPost]
        public HttpResponse Login(LoginInputModel input)
        {
            string userId = this.usersService.GetUserId(input.Username, input.Password);

            if(userId != null)
                this.SignIn(userId);

            return this.Redirect("/");
        }

        public HttpResponse Register()
        {
            return this.View();
        }

        [HttpPost]
        public HttpResponse Register(RegisterInputModel inputModel)
        {
            this.usersService.CreateUser(inputModel.Username, inputModel.Email, inputModel.Password);

            return this.Redirect("/Users/Login");
        }

        public HttpResponse Logout()
        {
            if (this.IsUserSignedIn())
                this.SignOut();

            return this.Redirect("/");
        }
    }
}
