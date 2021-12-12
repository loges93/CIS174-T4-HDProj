using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team4_FinalProject.Controllers
{
    public class NoteController : Controller
    {
        public IActionResult Add(int id)
        {
            return View();
        }
    }
}
