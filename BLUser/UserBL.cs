using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DACOVIDWEB;

namespace BLUser
{
    public class UserBL
    {
        public static bool create(tbl_user user)
        {
            return UserDA.create(user);

        }
        public static bool create(tbl_user user , tbl_user_attribute userAttribute)
        {
            return UserDA.create(user, userAttribute);

        }


        public static tbl_user getByDNI(String dni)
        {
            return UserDA.getByDNI(dni);

        }

        
        public static tbl_user getByDNIandPassword(String dni,String pass)
        {
            return UserDA.getByDNIandPassword(dni,pass);

        }

        public static List<tbl_user> getPersonsVulnerable()
        {


            return UserDA.getPersonsVulnerable();

        }


    }
}
