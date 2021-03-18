using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagnificentPlaceholder.Controllers
{
    public class Search : Controller
    {
        [HttpPost]
        public ActionResult PerformSearch(string searchText)
        {
            // Demonstrating reaching out to an api serverside
            return View("~/SearchResults");
        }
    }
}