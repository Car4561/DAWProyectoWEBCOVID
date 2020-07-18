using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Validation;

using System.Text;
using System.Threading.Tasks;

using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;

namespace DACOVIDWEB
{
    public class DonationDA
    {

        public static bool create(tbl_donation donation){

            using (var data = new ProyectoCovidDAW2020Entity())
            {



                data.tbl_donation.Add(donation);
                data.SaveChanges();
                return true;


            }
            return false;
        }

        public static List<tbl_donation>  getAllDonations()
        {

                var data = new ProyectoCovidDAW2020Entity();
          
                return data.tbl_donation.ToList();

      
        }
        
        public static List<tbl_donation> getDonationsForDelivery()
        {

            var data = new ProyectoCovidDAW2020Entity();

            return data.tbl_donation.Where(x => x.state == 4 || x.state == 1).ToList();


        }

        public static bool updateDonationState(int idDonation,int state)
        {

            using (var data = new ProyectoCovidDAW2020Entity())
            {
              
                    tbl_donation donation = data.tbl_donation.Where(x => x.id == idDonation).FirstOrDefault();
                    if (donation == null)
                    {
                        return false;
                    }
                    donation.state = state;
                    if (state == 4)
                    {
                        donation.fecha_assign = DateTime.Now;
                    }
                    else if (state == 1) {
                     
                        donation.fecha_delivery = DateTime.Now;

                     }


                   data.SaveChanges();
                    return true;

              
            }
        }
        public static bool AssignDonation(int idDonation,int idPerson)
        {

                var data = new ProyectoCovidDAW2020Entity();

                tbl_donation donation = data.tbl_donation.Where(x => x.id == idDonation).FirstOrDefault();
                if (donation == null)
                {
                    return false;
                }
                donation.tbl_user_person = idPerson;
                donation.state = 4;
                   donation.fecha_assign = DateTime.Now;

                data.SaveChanges();
                return true;


        }

   
    }
}
