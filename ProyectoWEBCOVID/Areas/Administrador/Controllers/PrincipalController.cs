using BLUser;
using DACOVIDWEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWEBCOVID.Areas.Administrador.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Administrador/Principal
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