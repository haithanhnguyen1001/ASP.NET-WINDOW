﻿using Microsoft.AspNetCore.Mvc;

namespace SV21T1080050.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id = 0)
        {
            return View();
        }
        public IActionResult EditDetail(int id = 0, int productId = 0)
        {
            return View();
        }
        public IActionResult Shipping(int id = 0)
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
