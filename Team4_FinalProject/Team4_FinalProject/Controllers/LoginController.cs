using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team4_FinalProject.Models;
using Team4_FinalProject.ViewModels;

namespace Team4_FinalProject.Controllers
{
    public class LoginController : Controller
    {
        private TicketManagerDbContext context;

        public LoginController(TicketManagerDbContext ctx)
        {
            context = ctx;
        }
        
        public IActionResult Index()
        {
            var model = new LoginViewModel();
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = context.Users.Single(u => u.Username == model.Username);
                if (user.Password == model.Password)
                {
                    TempData["cu_username"] = user.Username;
                    TempData["cu_id"] = user.UserId;
                    TempData["cu_first"] = user.FirstName;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Passwords Do Not Match");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
           
        }
    }
}
