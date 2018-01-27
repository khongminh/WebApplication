using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCNetCore.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Welcome(string name, int age)
		{
			ViewData["name"] = name;
			ViewData["age"] = age;
			return View();
		}
    }
}