using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;
namespace SupplierDemo.WebUI.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public ActionResult Index()
        {
            string a = service.Get();
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
    }
}