//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbMaestro
    {
        public string MatriculaTBMaes { get; set; }
        public string NombreTBMaes { get; set; }
        public string ApPaternoTBMaes { get; set; }
        public string ApMaternoTBMaes { get; set; }
        public string DireccionTBMaes { get; set; }
        public string TelefonoTBMaes { get; set; }
        public string EmailTBMaes { get; set; }
        public System.Guid ClienteIDTBMaes { get; set; }
        public bool EliminarTBMaes { get; set; }
        public int DepartamentoIDTBMaes { get; set; }
        public Nullable<bool> PrestamoEspecialTBMaes { get; set; }
    
        public virtual tbCliente tbCliente { get; set; }
        public virtual tbDepartamento tbDepartamento { get; set; }
    }
}
