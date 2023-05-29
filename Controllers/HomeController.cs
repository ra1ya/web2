using homeworkreverse.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace homeworkreverse.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
       
        [HttpPost]
        public IActionResult Index(string name)
        {
            
            char[] charArry = name.ToCharArray();
            Array.Reverse(charArry);
            string reversedName = new string(charArry);
            ViewBag.ReversedName = reversedName;
            return View();
            


        }

        
    }
}