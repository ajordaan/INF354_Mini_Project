﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using INF354_MiniProj.Models;

namespace INF354_MiniProj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string searchterm = null)
        {
            ViewBag.Message = "Your application description page.";

            var _db = new furnatureEntities();

            IQueryable<customer> custQuery = 
                from cust in _db.customers
                where cust.email == searchterm
                select cust;

            return View(custQuery);
            
           
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}