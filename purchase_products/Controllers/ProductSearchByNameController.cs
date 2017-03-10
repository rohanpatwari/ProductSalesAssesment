using purchase_products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace purchase_products.Controllers
{
    public class ProductSearchByNameController : Controller
    {

        private AdventureWorks2012Entities db = new AdventureWorks2012Entities();
        // GET: Product
        public ActionResult ProductSearchByKey(string searchstring)
        {
            var prod = from p in db.Products
                       select p;
            if (!String.IsNullOrEmpty(searchstring))
            {
                prod = prod.Where(s => s.Name.Contains(searchstring));
            }
            return View(prod);
        }
    }
}