﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gbkapp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gbkapp.Controllers
{
    public class ProductsController : Controller
    {
        private gbkingdomContext db = new gbkingdomContext();
        public IActionResult Index()
        {
            return View();
        }
    }
}
