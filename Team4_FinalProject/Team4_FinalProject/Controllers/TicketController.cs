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

        [HttpGet]
        public ViewResult Add() => View();

        [HttpPost]
        public IActionResult Add(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                // code that adds ticket to database
                return View("Detail");  // redirect to view all tickets page
            }
            else // return to add page with error details
            {
                return View(ticket);
            }
        }

        public IActionResult Detail()
        {
            return View("Detail");
        }
    }
}
