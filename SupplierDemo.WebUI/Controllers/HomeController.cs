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
using Newtonsoft.Json;

namespace SupplierDemo.WebUI.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            using (ServiceReference1.Service1Client service = new ServiceReference1.Service1Client())
            {
                var resp = service.GetStocks();
                HomePageVM homePageVM = new HomePageVM()
                {
                    stocks = resp.Stock,
                    suppliers = resp.Supp
                };
                return View(homePageVM);
            }
        }
        [HttpPost]
        public string GetCurStock(string supId)
        {
            using (ServiceReference1.Service1Client service = new ServiceReference1.Service1Client())
            {
                List<StockVM> resp = service.GetOnlyStock();
                XmlBackUp(resp, supId, "select");
                return JsonConvert.SerializeObject(resp.OrderBy(x => x.Quatity));
            }
        }

        public string UpdateStock(int newStock, int stockId, string supId)
        {
            using (ServiceReference1.Service1Client service = new ServiceReference1.Service1Client())
            {
                var resp = service.UpdateStock(stockId, newStock);
                XmlBackUp(resp, supId, "update");
                return JsonConvert.SerializeObject(resp.OrderBy(x => x.Quatity));
            }
        }

        public void XmlBackUp(List<StockVM> resp, string supId, string type)
        {
            XmlSerializer ser = new XmlSerializer(typeof(StockVM));
            string curName = supId + " " + DateTime.Now.ToString().Replace(".", "-").Replace(":", ";");
            string savePath = Server.MapPath(@"/XMLBackUP/" + curName + " " + type + "  +.xml");
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
        }
    }
}