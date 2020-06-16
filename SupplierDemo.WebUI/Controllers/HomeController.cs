using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;
using SupplierDemo.Entites.Entities;
using SupplierDemo.StockServices.Model;

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
                suppliers = resp.Supp
            };

            return View(homePageVM);
        }
        [HttpPost]
        public List<StockVM> GetCurStock(string supId)
        {

            List<StockVM> resp = service.GetOnlyStock();


            return resp;
        }


    }
}