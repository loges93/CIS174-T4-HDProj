using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team4_FinalProject.Models;

namespace Team4_FinalProject.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View("List");
        }

        public IActionResult Add()
        {
            if (ModelState.IsValid)
            {
                // code that adds ticket to database
                return RedirectToAction("Ticket");  // redirect to view all tickets page
            }
            else // Return to add ticket page w/ error message
            {
                return View("Add");
            }
        }

        public IActionResult Detail()
        {
            return View("Detail");
        }
    }
}
