using SweetAlertWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetAlertWeb.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View(new OrderFood());
        }

        [HttpPost]
        public ActionResult Create(OrderFood OrderFood)
        {
            if (ModelState.IsValid)
            {

            }
            else
            {

            }
            return View(OrderFood);
        }
    }
}