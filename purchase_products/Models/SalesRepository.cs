using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using purchase_products.Models;

namespace purchase_products.Models
{
    class SalesRepository
    {
        //CRUD OPERATIONS // Generic Type
        public AdventureWorks2012Entities advDataContext;  
        public SalesRepository()
            {
               advDataContext = new AdventureWorks2012Entities();
            }      
        public IList<SalesOrderDetail> GetSales()
        {
           List<SalesOrderDetail> lstSalesOrders = advDataContext.SalesOrderDetails.ToList();
           return lstSalesOrders;
        }

        public void CreateSalesOrder()
        {
            SalesOrderDetail salesOrder = new SalesOrderDetail();
            salesOrder.CarrierTrackingNumber = "1234456";
            salesOrder.LineTotal = 10;
            //salesOrder.ModifiedDate = ;
            salesOrder.OrderQty = 4;
            salesOrder.ProductID = 123;
            salesOrder.UnitPrice = 90;

            advDataContext.SalesOrderDetails.Add(salesOrder);
            advDataContext.SaveChanges();
        }

        public void UpdateSalesOrder(int id)
        {
            SalesOrderDetail salesOrder= advDataContext.SalesOrderDetails.Where(s => s.SalesOrderDetailID == id).FirstOrDefault();

            salesOrder.CarrierTrackingNumber = "12344";
            salesOrder.LineTotal = 140;
            //salesOrder.ModifiedDate = ;
            salesOrder.OrderQty = 44;
            salesOrder.ProductID = 1523;
            salesOrder.UnitPrice = 950;

            advDataContext.SaveChanges();
        }

        public void RemoveSalesOrder(int id)
        {
            SalesOrderDetail salesOrder=advDataContext.SalesOrderDetails.Where(s => s.SalesOrderDetailID == id).FirstOrDefault();
            advDataContext.SalesOrderDetails.Remove(salesOrder);

            advDataContext.SaveChanges();
        }


        //GENERIC TYPE
        //public IList<T> Get<T>()
        //{
        //    List<T> lstRecords = advDataContext;
        //    return lstRecords;
        //}

       
    }
}