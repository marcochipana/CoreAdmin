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
    
    public partial class empresa
    {
        public long embi_empresa_id { get; set; }
        public string emvc_nombre_empresa { get; set; }
        public string emvc_sucursal_empresa { get; set; }
        public string emvc_nit_empresa { get; set; }
        public string emvc_direccion_empresa { get; set; }
        public string emvc_telefono_empresa { get; set; }
        public string emvc_cel_empresa { get; set; }
        public string lxvc_ciudad { get; set; }
        public Nullable<System.DateTime> emdt_fecha_insert { get; set; }
        public string emvc_user_insert { get; set; }
        public Nullable<System.DateTime> emdt_fecha_modif { get; set; }
        public string emvc_user_modif { get; set; }
        public bool embt_is_hidden { get; set; }
    }
}
