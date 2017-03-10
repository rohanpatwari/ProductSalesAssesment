using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using purchase_products.Models;

namespace purchase_products.Controllers
{
    public class SalesOrderController : Controller
    {
        // GET: SalesOrder
        public ActionResult GetSalesOrders()
        {
            SalesRepository repository = new SalesRepository();
            IList<SalesOrderDetail> lstSalesOrders = repository.GetSales().Where(s=>s.SalesOrderID == 43665).ToList();
            return View(lstSalesOrders);
        }

        public ActionResult GetSalesOrdersById(int id)
        {
            SalesRepository repository = new SalesRepository();
            IList<SalesOrderDetail> lstSalesOrders= repository.GetSales().Where(s=>s.SalesOrderID == id).ToList();
            return View(lstSalesOrders);
        }
    }
}