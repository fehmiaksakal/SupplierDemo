using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;
using SupplierDemo.Entites.Entities;

namespace SupplierDemo.WebUI.Controllers
{
    public class HomeController : Controller
    {
       ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

        public ActionResult Index()
        {

            var resp = service.GetStocks();
            HomePageVM homePageVM = new HomePageVM()
            {
                stocks = resp.Stock,
                //suppliers = resp.Supp
            };

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