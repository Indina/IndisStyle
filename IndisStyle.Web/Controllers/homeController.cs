using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndisStyle.Web.Controllers
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

        public ActionResult Portfolio()
        {
            return View();
        }
        public ActionResult Tjenester()
        {
            return View();
        }

        public ActionResult LagEnKravspek()
        {
            return View();
        }
    }
}
