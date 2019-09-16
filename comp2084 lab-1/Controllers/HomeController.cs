using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using comp2084_lab_1.Models;

namespace comp2084_lab_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult addition(int a, int b)
        {
            ViewData["Message"] = "Your contact page.";

            return Ok("result ="+(a+b).ToString());
        }

        public IActionResult multiply(int a, int b)
        {
            ViewData["Message"] = "Your contact page.";

            return Ok("result =" + (a * b).ToString());
        }
    }
}
