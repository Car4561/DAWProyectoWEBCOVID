using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLUser;
using DACOVIDWEB;
namespace ProyectoWEBCOVID.Areas.Web.Controllers
{
    public class DonationController : Controller
    {




        public ActionResult Register()
        {

            return View();

        }

        [HttpPost]
        public ActionResult Register(tbl_donation donation)
        {


            return Json(DonationBL.create(donation));

        }

        public ActionResult List()
        {

            ViewBag.listDonations = DonationBL.getAllDonations();
            return View();

        }

        public ActionResult Delivery()
        {

            ViewBag.listDonations = DonationBL.getDonationsForDelivery();
            return View();

        }


        public ActionResult Categories()
        {


            return Json(CategoryDonationsBL.getCategoriesDonation(), JsonRequestBehavior.AllowGet);

        }

        public ActionResult Persons()
        {


            return Json(UserBL.getPersonsVulnerable(), JsonRequestBehavior.AllowGet);

        }



        [HttpPost]
        public ActionResult Confirm(int idDonation)
        {


            return Json(DonationBL.updateDonationState(idDonation, 3), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult AssignDonation(int idDonation, int idPerson)
        {

            return Json(DonationBL.AssignDonation(idDonation, idPerson));

        }


        [HttpPost]
        public ActionResult Delivery(int idDonation)
        {


            return Json(DonationBL.updateDonationState(idDonation, 1), JsonRequestBehavior.AllowGet);

        }
    }
}