using lab2LenguajesDaniel.Models;
using lab2LenguajesDaniel.Models.Data;
using lab2LenguajesDaniel.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lab2LenguajesDaniel.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDAO _studentDAO;

        public HomeController(StudentDAO studentDAO)
        {
            _studentDAO = studentDAO;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentDAO.InsertStudent(student);
                return RedirectToAction("Privacy");
            }
            return View(student);
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
