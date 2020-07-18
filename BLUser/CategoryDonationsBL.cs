using DACOVIDWEB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLUser
{
    public class CategoryDonationsBL
    {   
        public static List<tbl_category_donation> getCategoriesDonation()
        {

            return CategoryDonationsDA.getCategoryDonations();

        }

    }
}
