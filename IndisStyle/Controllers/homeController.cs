using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndisStyle.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult OmMeg()
        {
            return View();
        }


        public ActionResult Arbeidsform()
        {
            return View();
        }

        public ActionResult Arkiv()
        {
            return View();
        }
        public ActionResult Prisliste()
        {
            return View();
        }

        public ActionResult LagEnKravspek()
        {
            return View();
        }
    }
}
