using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPruebas1.Controllers
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



        public JsonResult GetFieldAttributes(string selectedField)
        {
            string a = selectedField;
            bool b = false;
            if (!(selectedField.Contains("some value")))
            {
                b = true;
            }

            var dataParms = new { aA = a, aB = b };
            return Json(dataParms, JsonRequestBehavior.AllowGet);
        }

        //public ViewResult ParPage1()
        //{
        //    return View();
        //}
        //public ViewResult ParPage2()
        //{
        //    return View();
        //}
        //public ActionResult Button1Clicked()
        //{
        //    ViewBag.Message1 = "Button1Clicked";
        //    return PartialView("ParPage1");
        //}
        //public ActionResult Button2Clicked(myData data)
        //{
        //    //Validate for duplicate data
        //    if (duplicate)
        //    {
        //        ViewBag.Message2 = "This data already exists in table. Please review";
        //    }
        //    else
        //    { SaveRecord(); }
        //    return PartialView("ParPage2");
        //}

    }
}