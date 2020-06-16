using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;
using SupplierDemo.Entites.Entities;
using SupplierDemo.StockServices.Model;
using System.Xml.Serialization;
using System.Xml.Linq;

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
            XmlSerializer ser = new XmlSerializer(typeof(StockVM));
            string curName = supId + " " + DateTime.Now.ToString().Replace(".","-").Replace(":", ";");
            string savePath = Server.MapPath(@"/XMLBackUP/" + curName + ".xml");
            var xmlSavePath = new XElement("Stocks",
                    from st in resp
                    select new XElement(
                            "Stock",
                                new XElement("StockId", st.StockId),
                                new XElement("SupplierName", st.SupplierId),
                                new XElement("ProductName", st.ProductId),
                                new XElement("Quantity", st.Quatity)
                        ));
            xmlSavePath.Save(savePath);
            return resp;
        }
    }
}