﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OliveInvest.Controllers
{
    public class AboutUsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "About Us - Olive Invest";
            return View();
        }
	}
}