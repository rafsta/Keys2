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

namespace Keys2.Controllers.API
{
    public class StoresController : ApiController
    {
        private Keys2Entities db;

        public StoresController()
        {
            db = new Keys2Entities();
        }

        //GET api/stores
        public IEnumerable<Store> GetStores()
        {
            return db.Stores.ToList();
        }

        //GET api/stores/id
        public Store GetStore(int id)
        {
            var store = db.Stores.SingleOrDefault(st => st.Id == id);

            if (store == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return store;
        }

        //POST api/stores
        [HttpPost]
        public Store CreateStore(Store store)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            db.Stores.Add(store);
            db.SaveChanges();

            return store;
        }

        //PUT /api/stores/1
        [HttpPut]
        public void UpdateStore(int id, Store store)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var storeInDb = db.Stores.SingleOrDefault(c => c.Id == id);

            if (storeInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            storeInDb.Name = store.Name;
            storeInDb.Address = store.Address;

            db.SaveChanges();
        }

        //DELETE /api/store/id
        [HttpDelete]
        public void DeleteStore(int id)
        {
            var storeInDb = db.Stores.SingleOrDefault(c => c.Id == id);

            if (storeInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            db.Stores.Remove(storeInDb);
            db.SaveChanges();
        }
    }
}