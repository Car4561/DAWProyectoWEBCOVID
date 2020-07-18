using DACOVIDWEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLUser
{
    public  class DonationBL
    {
        public static bool create(tbl_donation donation)
        {
            return DonationDA.create(donation);

        }

        public static List<tbl_donation> getAllDonations()
        {
            return DonationDA.getAllDonations();

        }
        public static List<tbl_donation> getDonationsForDelivery()
        {
            return DonationDA.getDonationsForDelivery();

        }



        public static bool updateDonationState(int id,int state)
        {

            return DonationDA.updateDonationState(id,state);

        }


        public static bool AssignDonation(int idDonation, int idPerson)
        {

          
            return DonationDA.AssignDonation(idDonation,idPerson);


        }
    }
}
