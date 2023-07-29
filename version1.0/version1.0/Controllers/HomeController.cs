using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using version1._0.Models;

namespace version1._0.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContex db = new DatabaseContex();

        public ActionResult Index()
        {
            var deliveryMethods = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Standard Delivery" },
            new SelectListItem { Value = "2", Text = "Express Delivery" },
            new SelectListItem { Value = "3", Text = "Next-Day Delivery" }

        };

            var paymentTerms = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Net 30 Days" },
            new SelectListItem { Value = "2", Text = "Net 60 Days" },
            new SelectListItem { Value = "3", Text = "Net 90 Days" }

        };


            ViewBag.DeliveryMethods = deliveryMethods.ToList();
            ViewBag.PaymentTerms = paymentTerms.ToList();



            var companiesDropdown1 = db.Companies.Select(c => new SelectListItem
            {
                Text = c.companyName,
                Value =  c.companyName+c.companyGstin+c.companyPanNo
              
            });

            ViewBag.Companies = new SelectList(companiesDropdown1, "Value", "Text");
            return View();
        }

        public ActionResult About()
        {
         
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}