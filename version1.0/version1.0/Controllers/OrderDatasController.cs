using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using version1._0.Models;

namespace version1._0.Controllers
{
    public class OrderDatasController : Controller
    {
        private DatabaseContex db = new DatabaseContex();

        // GET: OrderDatas
        public ActionResult Index()
        {
            return View(db.OrderDatas.ToList());
        }

        // GET: OrderDatas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderData orderData = db.OrderDatas.Find(id);
            if (orderData == null)
            {
                return HttpNotFound();
            }
            return View(orderData);
        }

        // GET: OrderDatas/Create
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,orderData1")] OrderData orderData)
        {
            if (ModelState.IsValid)
            {
                db.OrderDatas.Add(orderData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orderData);
        }

      
        [HttpPost]
        public string GenerateOrderPreview([Bind(Include = "orderData")] string orderData)
        {
            // Create a view to display the order preview
            Console.WriteLine( "data found ");
            return orderData
                ;
                
        }
    }
}
