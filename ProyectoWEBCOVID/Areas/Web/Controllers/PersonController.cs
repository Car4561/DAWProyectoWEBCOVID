using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLUser;
using DACOVIDWEB;
namespace ProyectoWEBCOVID.Areas.Web.Controllers
{
    public class PersonController : Controller
    {
        // GET: Web/Person
        public ActionResult Register()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Register(tbl_user user, tbl_user_attribute userAttribute)
        {

            /* User user = new User();
             user.DNI = dni;
             user.password = password;
             user.created_by = "web";
             user.tbl_role_id = 1;
            */

            return Json(UserBL.create(user, userAttribute));


        }

    }
}