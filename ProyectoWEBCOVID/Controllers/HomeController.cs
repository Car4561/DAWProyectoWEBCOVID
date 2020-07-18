using BLUser;
using DACOVIDWEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ProyectoWEBCOVID.Controllers
{
    public class HomeController : System.Web.Mvc.Controller
    {
        public ActionResult Index()
        {
            
            if (Session["isLogin"] != null) {
                if ((bool)Session["isLogin"] == true)
                {
                    if ((int)Session["idRole"] == 1)
                    {

                        return RedirectToAction("Index", "Principal", new { Area = "Administrador" });

                    }else {

                        return RedirectToAction("Index", "Principal", new { Area = "Web" });

                    }


                }
                  
            
            }
                
            return RedirectToAction("Login");

        }

        public ActionResult Login() {



            if (Session["isLogin"] != null)
            {
                if ((bool)Session["isLogin"] == true)
                {
                    if ((int)Session["idRole"] == 1)
                    {

                        return RedirectToAction("Index", "Principal", new { Area = "Administrador" });

                    }
                    else
                    {

                        return RedirectToAction("Index", "Principal", new { Area = "Web" });

                    }

                }


            }

            return View();

        }

        [HttpPost]
        public ActionResult Login(string dni,string pass)
        {
            bool isLogin = false;
            int idRole = 0;
            tbl_user user = UserBL.getByDNIandPassword(dni, pass);
            if (user != null) {
                isLogin = true;
                Session["user"] = user;
                Session["idUser"] = user.id;
                Session["idRole"] = user.tbl_role_id;
                idRole = user.tbl_role_id;
                Session["fullname"] = user.name + " "+ user.surname;
                Session["isLogin"] = true;
                
            }

            var session = Session;

            return Json(new { isLogin = isLogin, idRole = idRole});

        }

        public ActionResult Register()
        {
            

            return View();

        }

     

        //string dni, string password,string name,string surname , string address, string phone

        [HttpPost]
        public ActionResult Register(tbl_user user)
        {

           /* User user = new User();
            user.DNI = dni;
            user.password = password;
            user.created_by = "web";
            user.tbl_role_id = 1;
           */
            
            return Json(UserBL.create(user));


        }



    }
}