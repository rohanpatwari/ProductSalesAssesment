using purchase_products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace purchase_products.Controllers
{
    public class AddressController : Controller
    {

        private AdventureWorks2012Entities db = new AdventureWorks2012Entities();
        // GET: Address
        public ActionResult AddressSearchByKey(string searchstring)
        {
            var Addr = from a in db.Addresses
                       select a;
            if (!String.IsNullOrEmpty(searchstring))
            {
                Addr = Addr.Where(s => s.AddressLine1.Contains(searchstring));
            }
            return View(Addr);
        }
    }
}