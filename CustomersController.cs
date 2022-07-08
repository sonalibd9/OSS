using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRMWebApp.Models;
namespace CRMWebApp.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            List<customer> c = customerManager.Lodedata();
            return this.Json(c, JsonRequestBehavior.AllowGet);
            return View(c);
            //comment from shubham tiware
             //comment from Suraj Dhande
        }
    }
}
//Hie Sonali ankita here
