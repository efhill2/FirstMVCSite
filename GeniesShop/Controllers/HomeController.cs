using GeniesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace GeniesShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        [HttpGet]
        public ActionResult Registration()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Summary(string firstname, 
            string lastname,
            string email,
            string phonenumber,
            string password,
            string pwconfirm,
            string state,
            string city,
            string choice)
        {
            User user = new User()
            {
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                PhoneNumber = phonenumber,
                Password = password,
                State = state,
                City = city,
                Choice = choice
            };

            if (password != pwconfirm)
            {
                ViewBag.PasswordStatusMessage = "Passwords do not match!! <br / >";
                return View("Registration");
            }
            else if ((!Regex.IsMatch(phonenumber, @"(\([0-9]{3}\)\-[0-9]{3}\-[0-9]{4})")) & ((!Regex.IsMatch(phonenumber, @"([0-9]{3}\.[0-9]{3}\.[0-9]{4})"))))
            {
                ViewBag.PhoneNumberStatusMessage = "Phone number needs to be in (XXX)-XXX-XXXX or (XXX).XXX.XXXX <br / >";
                return View("Registration");
            }
            else
            {
                return View(user);
            }

             
        }

    }
}