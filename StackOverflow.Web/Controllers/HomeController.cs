using Microsoft.AspNetCore.Mvc;
using StackOverflow.Web.Models;
using System.Diagnostics;

namespace StackOverflow.Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        
    }
}