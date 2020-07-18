using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace DACOVIDWEB
{
    public class UserDA
    {
        public static bool create(tbl_user user)
        {

            var data = new ProyectoCovidDAW2020Entity();
            data.tbl_user.Add(user);
            data.SaveChanges();
            return true;

          

        }

        public static bool create(tbl_user user,tbl_user_attribute userAttribute)
        {

            var data = new ProyectoCovidDAW2020Entity();
        
            data.tbl_user.Add(user);
         
            data.SaveChanges();
    

            var lastShowPieceId = data.tbl_user.Max(x => x.id);
            userAttribute.tbl_user_id = lastShowPieceId;
            data.tbl_user_attribute.Add(userAttribute);
            data.SaveChanges();

            return true;

        }


          


        public static tbl_user getByDNIandPassword(String dni,String pass)
        {

                var data = new ProyectoCovidDAW2020Entity();
                data.Configuration.LazyLoadingEnabled = true;
                tbl_user user = data.tbl_user.Include("tbl_donation").Where(x => x.DNI == dni && x.password == pass).FirstOrDefault();
                return user;




        }


        public static tbl_user getByDNI(String dni) {

               var data = new ProyectoCovidDAW2020Entity();

                data.Configuration.LazyLoadingEnabled = false;
                tbl_user user = data.tbl_user.Where(x => x.DNI == dni).FirstOrDefault();
                return user;

           


        }

        public static List<tbl_user> getPersonsVulnerable()
        {


            using (var data = new ProyectoCovidDAW2020Entity()) { 
                data.Configuration.LazyLoadingEnabled = false;
                return data.tbl_user.Include("tbl_user_attribute").Where(x => x.tbl_role_id == 3).ToList();

          }


        }







    }
}
