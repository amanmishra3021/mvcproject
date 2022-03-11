using mvcproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcproject.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
           employee data = new employee();
            data.empid = 1234;
            data.empname = "Aman Mishra";
            data.salary = 15000;

            ViewBag.ab = "pragati";
            ViewBag.text1 = 1234;
            ViewBag.text2 = 34.9F;
            ViewBag.my = "that is the super class";





            ViewBag.list = new List<string>()
            {
                "I",
                "lOVE",
                "MY India"

            };




           return View(data);

        }


        public ActionResult About()
        {
            ViewData["xyz"] = "rahul";
            ViewData["id"] = 1456;
            ViewData["city"] = "noida";
            ViewData["state"] = "up";

            ViewData["abc"] = new List<string>()
            {
                "home",
                "about",
                "controller"
            };
            Session["empname"] = "AMAN MISHRA ";
            Session["empid"] = 45667;
            Session["empcity"] = "delhi";
            Session["empstate"] = "uk";
            Session["session"] = new List<string>()
            {
                 "INDIA",
                "pakista",
                "canada"

            };

            return View();
        }

        public ActionResult Contact()
        {
            TempData["abc"] = "hello my india";
            TempData["abc1"] = 234;
            TempData["abc2"] = 2.4F;
            TempData["abc3"] = DateTime.Now;
            TempData["ABC1"] = "MY INDIA SUPER COUNTRY";
            TempData["pragam"] = new List<string>()
            {
                "INDIA",
                "pakista",
                "canada"
            };



            return View();    
        }
    }
}