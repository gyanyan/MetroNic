using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroNicMvc.Controllers
{
    public class BlankPageController : Controller
    {
        //
        // GET: /TestLayout/
        public ActionResult Index()
        {
            return View();
        }
    }
}