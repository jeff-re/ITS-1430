﻿/*
 * Geoffrey Kio
 * ITSE 1430
 * 12/8/2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nile.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index ()
        {
            return View ();
        }

        public ActionResult About ()
        {
            ViewBag.Message = "Your application description page.";

            return View ();
        }

        public ActionResult Contact ()
        {
            ViewBag.Message = "Your contact page.";

            return View ();
        }
    }
}