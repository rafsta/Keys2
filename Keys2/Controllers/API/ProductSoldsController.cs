using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Keys2.Models;
using Keys2.Controllers;

namespace Keys2.Controllers.API
{
    public class ProductSoldsController : ApiController
    {
        private Keys2Entities db;
        public ProductSoldsController()
        {
            db = new Keys2Entities();
        }

        //GET api/sales
        public IEnumerable<ProductSold> Getsales()
        {
            var productSolds = db.ProductSolds.ToList();

            return productSolds;
        }

        //GET api/sales/id
        public ProductSold Getsales(int id)
        {
            var productSold = db.ProductSolds.SingleOrDefault(ps => ps.Id == id);

            if (productSold == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return productSold;
        }

        //POST api/sales
        [HttpPost]
        public ProductSold CreateSales(ProductSold productSold)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            db.ProductSolds.Add(productSold);
            db.SaveChanges();

            return productSold;
        }

        //PUT /api/sales/id
        [HttpPut]
        public void UpdateSales(int id, ProductSold productSold)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var productSoldInDb = db.ProductSolds.SingleOrDefault(ps => ps.Id == id);

            if (productSoldInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            productSoldInDb.DateSold = productSold.DateSold;
            productSoldInDb.CustomerId = productSold.CustomerId;
            productSoldInDb.ProductId = productSold.ProductId;
            productSoldInDb.StoreId = productSold.StoreId;

            db.SaveChanges();
        }

        //DELETE /api/sales/id
        [HttpDelete]
        public void DeleteSales(int id)
        {
            var productSoldInDb = db.ProductSolds.SingleOrDefault(c => c.Id == id);

            if (productSoldInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            db.ProductSolds.Remove(productSoldInDb);
            db.SaveChanges();
        }
    }
}