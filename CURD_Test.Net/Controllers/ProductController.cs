using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CURD_Test.Net.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace CURD_Test.Net.Controllers
{
    
    
    public class ProductController : Controller
    {
        private readonly IMongoCollection<ProductModel> _DatabaseService;
        public ProductController()
        {
            var client = new MongoClient("mongodb+srv://chokchai9900:wnY4NpPAGjMdGK4@setzerocluster-dig6r.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("WebData");

            _DatabaseService = database.GetCollection<ProductModel>("ProductDB");
        }
        // GET: Product
        public ActionResult Index()
        {
            var data = _DatabaseService.Find(it => true).ToEnumerable();
            return View(data);
        }

        // GET: Product/Details/5
        public ActionResult Details(string id)
        {
            var data = _DatabaseService.Find(it => it._id == id).FirstOrDefault();
            return View(data);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel ProductData)    
        {
            var result = String.Join("", ($"{DateTime.Now.Millisecond}{DateTime.Now.ToString("yyyyMMddHHmmss")}"));
            try
            {
                ProductData._id = result;
                ProductData.FirstImportedDatetime = DateTime.Now;
                ProductData.LastUpdateDatetime = DateTime.Now;
                _DatabaseService.InsertOne(ProductData);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(string id)
        {
            var data = _DatabaseService.Find(it => it._id == id).FirstOrDefault();
            return View(data);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, ProductModel ProductData)
        {
            try
            {
                var def = Builders<ProductModel>.Update
                    .Set(it => it.name, ProductData.name)
                    .Set(it => it.brand, ProductData.brand)
                    .Set(it => it.discription, ProductData.discription)
                    .Set(it => it.price, ProductData.price)
                    .Set(it => it.countOfProduct, ProductData.countOfProduct)
                    .Set(it => it.name, ProductData.name)
                    .Set(it => it.LastUpdateDatetime,DateTime.Now);
                //_DatabaseService.ReplaceOne(it => it._id == id, ProductData);
                _DatabaseService.UpdateOne(it => it._id == ProductData._id, def);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(string id ,ProductModel ProductData)
        {
            _DatabaseService.DeleteOne(it => it._id == id);

            return RedirectToAction(nameof(Index));
        }

        //// POST: Product/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(string id, ProductModel ProductData)
        //{
        //    try
        //    {
        //        _DatabaseService.DeleteOne(it => it._id ==id);

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}