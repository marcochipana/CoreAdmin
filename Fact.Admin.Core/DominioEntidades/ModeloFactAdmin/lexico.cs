//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DominioEntidades.ModeloFactAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class lexico
    {
        public int idlexico { get; set; }
        public string lxvc_tabla { get; set; }
        public string lxvc_tema { get; set; }
        public string lxvc_valor { get; set; }
        public string lxvc_desc { get; set; }
        public string lxvc_desc_larga { get; set; }
        public Nullable<System.DateTime> lxdt_fecha_insert { get; set; }
        public string lxvc_user_insert { get; set; }
        public Nullable<System.DateTime> lxdt_fecha_modif { get; set; }
        public string lxvc_user_modif { get; set; }
        public Nullable<bool> lxbt_is_hidden { get; set; }
    }
}
