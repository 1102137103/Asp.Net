﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0314.Areas.Emp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Emp/Default
        public ActionResult Index()
        {
            ViewBag.Desc = "Hello Emp";
            return View();
        }
    }
}