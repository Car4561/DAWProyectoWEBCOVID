using BLUser;
using DACOVIDWEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ProyectoWEBCOVID.Areas.Web.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Web/Principal
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home", new { Area = "" });

        }


    }
}