﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wtw.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Statistics()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Navigation()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Rules()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Forum()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}