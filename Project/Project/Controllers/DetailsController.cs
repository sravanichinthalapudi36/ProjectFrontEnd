using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Index()
        {
            var Items = GetItems();
            return View(Items);
        }
        private IEnumerable<Items> GetItems()
        {
            return new List<Items>{
               new Items{selectedamount=1,name="Apple Pie",price=1275,totolprice=1275},
               new Items{selectedamount=1,name="Pumpkin Pie",price=3075,totolprice=3075},
                new Items{selectedamount=1,name="RhubarbPie",price=1275,totolprice=1275}
            };
        }
        public ActionResult Details(int selectedamount)
        {
            var Items = GetItems().SingleOrDefault(d => d.selectedamount == selectedamount);
            if (Items == null)
                return HttpNotFound();
            return View(Items);

        }
    }
}