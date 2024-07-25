using HomeWork1.Entities;
using HomeWork1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork1.Controllers
{
    public class HomeController : Controller
    {

        public static List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id = 1,
                    Name = "Coca-Cola",
                    Price = 1.20f
                },
                new Drink
                {
                    Id = 2,
                    Name = "Fanta",
                    Price = 1.10f
                },
                new Drink
                {
                    Id = 3,
                    Name = "Pepsi",
                    Price = 1.30f
                },
                new Drink
                {
                    Id = 4,
                    Name = "Orange Juice",
                    Price = 1.50f
                }
            };

        public static List<Hotmeal> hotmeals = new List<Hotmeal>
            {
                new Hotmeal
                {
                    Id = 1,
                    Name = "Chicken Soup",
                    Description = "Chicken + Vegetables",
                    Price = 2.50f
                },
                new Hotmeal
                {
                    Id = 2,
                    Name = "Rice",
                    Description = "Just rice",
                    Price = 2.20f
                },
                new Hotmeal
                {
                    Id = 3,
                    Name = "Buffalo wings",
                    Description = "Chicken wings + seasonings",
                    Price = 3.10f
                }
            };

        public static List<Fastfood> fastfoods = new List<Fastfood>
            {
                new Fastfood
                {
                    Id = 1,
                    Name = "Burger",
                    Description = "Bread + meat",
                    Price = 2.10f
                },
                new Fastfood
                {
                    Id = 2,
                    Name = "Cheeseburger",
                    Description = "Bread + meat + cheese",
                    Price = 2.30f
                },
                new Fastfood
                {
                    Id = 3,
                    Name = "Potato chips",
                    Description = "Cut potatoes",
                    Price = 1.10f
                },
                new Fastfood
                {
                    Id = 4,
                    Name = "Chicken nuggets",
                    Description = "Just chicken",
                    Price = 3.20f
                },
                new Fastfood
                {
                    Id = 5,
                    Name = "Tacos",
                    Description = "I don't know the ingridients...",
                    Price = 1.50f
                }
            };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Drinks()
        {
            return View(drinks);
        }

        public IActionResult Hotmeals()
        {
            return View(hotmeals);
        }

        public IActionResult Fastfoods()
        {
            return View(fastfoods);
        }

        public IActionResult Foods()
        {

            FoodsViewModel fvm = new FoodsViewModel()
            {
                Drinks = drinks,
                Fastfoods = fastfoods,
                Hotmeals = hotmeals
            };

            return View(fvm);
        }

    }
}
