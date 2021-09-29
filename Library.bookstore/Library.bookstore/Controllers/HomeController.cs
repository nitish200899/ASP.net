using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.bookstore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var obj = new { id = 1, name = "nitish" };
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View();
        }
    }
}
