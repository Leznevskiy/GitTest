using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GitTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GitTest.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public ActionResult index()
        {
            return View();
        }
    }
}
