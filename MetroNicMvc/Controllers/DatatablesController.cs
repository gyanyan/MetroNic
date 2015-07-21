using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroNicMvc.Controllers
{
    public class DatatablesController : Controller
    {
        public ActionResult BasicTable()
        {
            return View();
        }

        public ActionResult DatatablesPlugin()
        {
            return View();
        }
    }
}