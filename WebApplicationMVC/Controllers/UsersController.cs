using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var model = new UsersModel();

            foreach (var user in Business.Genericos.User.Users)
            {
                model.Users.Add(new UserModel() {
                    Id = user.Id,
                    Name = user.Name,
                    Nickname = user.Nickname,
                    Email = user.Email,
                    Password = user.Password,
                    AccessType = user.AccessType,
                    });
            }

            // Redireciona para o arquivo Index.cshtml na pasta Users
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserModel userModel)
        {
            var usuarioCadastro = new Business.Genericos.User()
            {
                Name = userModel.Name,
                Nickname = userModel.Nickname,
                Email = userModel.Email,
                Password = userModel.Password,
                AccessType = userModel.AccessType,
            };

            Business.Genericos.User.Users.Add(usuarioCadastro);
            return RedirectToAction("Index");
        }
    }
}