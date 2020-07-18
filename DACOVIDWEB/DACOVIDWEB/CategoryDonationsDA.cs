using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACOVIDWEB
{
   public  class CategoryDonationsDA
    {
        public static List<tbl_category_donation> getCategoryDonations() {

            using (var data = new ProyectoCovidDAW2020Entity() ) {

                 data.Configuration.LazyLoadingEnabled = false;
                 return data.tbl_category_donation.ToList();

           }
            
        }
    }
}
