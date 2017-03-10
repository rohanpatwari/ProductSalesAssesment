using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace purchase_products.Models
{
    public class ProductRepository
    {
        //CRUD OPERATIONS // Generic Type
        public AdventureWorks2012Entities advDataContext;
        public ProductRepository()
        {
            advDataContext = new AdventureWorks2012Entities();
        }
        public void GetSalesofProduct()
        {
            var lstSalesOrder = (from s in advDataContext.SalesOrderDetails
                                 join o in advDataContext.SpecialOfferProducts
                                 on
                                 s.ProductID equals o.ProductID
                                 join p in advDataContext.Products
                                 on
                                 o.ProductID equals p.ProductID

                                 select new
                                 {
                                     ProductIdSold = s.ProductID,
                                     ProductName = p.Name
                               }).ToList();       
        }


    }
}