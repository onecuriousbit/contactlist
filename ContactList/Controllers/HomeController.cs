﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToRoute("HelpPage_Default");
        }
    }
}
