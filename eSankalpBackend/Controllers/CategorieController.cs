using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSankalpBackend.Controllers
{
    public class CategorieController : Controller
    {
        // GET: Categorie
        public ActionResult CategoryIndex()
        {
            return View();
        }
    }
}