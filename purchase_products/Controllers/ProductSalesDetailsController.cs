using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using purchase_products.Models;

namespace purchase_products.Controllers
{
    public class ProductSalesDetailsController : Controller
    {
        // GET: ProductSalesDetails

        public ActionResult GetProductsSold()
        {
            ProductRepository prdRepo = new ProductRepository();
            prdRepo.GetSalesofProduct();

            return View();
        }
    
    }
}