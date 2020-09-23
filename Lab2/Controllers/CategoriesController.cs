using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab2.Models;

namespace Lab2.Controllers
{

    
    /// controller called CategoriesController
    
    public class CategoriesController : Controller
    {
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ILogger<CategoriesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }




        /// method called Details that accepts 1 string parameter
        /// This method sends back a string to the view using the 
        /// ViewBag that says "You selected category: [paramater-value-here]"
        
        public IActionResult Details(String category)
        {
            ViewBag.category = category;
            return View();
        }

        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}