using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace SaveTest.Controllers
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

        public JsonResult FullName(string fullName)
        {
            //String Null Or Empty Return Fail
            if(string.IsNullOrWhiteSpace(fullName))
            {
                return Json(new
                {
                    Success = false
                }); 
            }

            //String Not Null Or Empty Try To Save To File
            try
            {
                string szDir = System.AppDomain.CurrentDomain.BaseDirectory;
                System.IO.StreamWriter file = new System.IO.StreamWriter(szDir + "\\FullName.txt");
                file.WriteLine(fullName);
                file.Close();
                
                return Json(new
                {
                    Success = true
                }); 
            }
            catch
            {
                return Json(new
                {
                    Success = false
                }); 
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}