using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using DataAbstraction;

namespace WebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Package data;

        public HomeController(ILogger<HomeController> logger)
        {
            data = new Package();            
            _logger = logger;
            
        }

        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Recipes()
        {
            List<GroceryListGenerator.Recipe> myList = data.GetRecipes(User.Identity.Name);
            return View(myList);
        }

        [HttpPost]
        public ActionResult Recipes(GroceryListGenerator.Recipe recipe)
        {
            List<GroceryListGenerator.Recipe> recipes = new List<GroceryListGenerator.Recipe>();
            recipes.Add(recipe);
            return View(recipes);
        }

        public IActionResult EditRecipe()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
