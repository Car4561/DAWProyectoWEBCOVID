//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DACOVIDWEB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_symptoms
    {
        public int id { get; set; }
        public int tbl_category_id { get; set; }
        public string name { get; set; }
        public Nullable<int> state { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string created_by { get; set; }
    
        public virtual tbl_category_symptoms tbl_category_symptoms { get; set; }
    }
}
