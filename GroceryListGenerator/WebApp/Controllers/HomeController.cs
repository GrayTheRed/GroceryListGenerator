﻿using Microsoft.AspNetCore.Authorization;
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
       

        public HomeController(ILogger<HomeController> logger)
        {
           GroceryListGenerator.Meal tempRecipe = new GroceryListGenerator.Meal("Bread", new List<GroceryListGenerator.Ingredient>
            {
                new GroceryListGenerator.Ingredient("Bread", 1.0, "Oz")
            });

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
            ViewBag.Ingredients = Package.GetRecipes(User.Identity.Name);
            return View();
        }

        [HttpPost]
        public ActionResult Recipes(GroceryListGenerator.Meal recipe)
        {
            List<GroceryListGenerator.Meal> recipes = new List<GroceryListGenerator.Meal>();
            recipes.Add(recipe);
            ViewBag.Ingredients = recipes;
            return View();
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
