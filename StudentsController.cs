using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stucore.Models;

namespace Stucore.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Students s)
        {
            if (ModelState.IsValid)
            {
                studentDBContext dBContext = new studentDBContext();
                dBContext.Add(s);
                dBContext.SaveChanges();
                return Content("Saved");
            }
            return View("Index");
        }
    }
}
