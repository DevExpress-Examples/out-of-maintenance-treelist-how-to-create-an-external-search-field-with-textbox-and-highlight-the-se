using DevExpress.Web.ASPxTreeList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchHighlight.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        Models.NORTHWNDEntities db = new Models.NORTHWNDEntities();
        public ActionResult TreeListPartial(string SearchText) {
            ViewData["SearchText"] = SearchText;
            return PartialView("_TreeListPartial", db.Employees.ToList());
        }

        public ActionResult TreeListCustomPartial(string SearchText, bool? isNewSearch) {
            ViewData["IsNewSearch"] = isNewSearch;
            ViewData["SearchText"] = SearchText;
            return PartialView("_TreeListPartial", db.Employees.ToList());
        }
    }
}