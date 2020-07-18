using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DACOVIDWEB
{
    public class UserDA
    {
        public bool create() {

            bool exito = true;
            using (var data = new CineDBEntities())
            {
                data.Pelicula.Add(pelicula);
                data.SaveChanges();
            }

            return exito;

        }



    }
}
