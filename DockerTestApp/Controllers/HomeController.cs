﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DockerTestApp.Models;

namespace DockerTestApp.Controllers
{
    public class HomeController : Controller
    {
        private ProductsDbContext _db;
        public HomeController(ProductsDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            _db.Products.Add(new Product { Name="Buljin product"});
            _db.SaveChanges();

            return View(_db.Products.First());
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
