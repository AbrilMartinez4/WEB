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
    
    public partial class tbEstado
    {
        public tbEstado()
        {
            this.tbMaterials = new HashSet<tbMaterial>();
        }
    
        public int EstadoIDTBEsta { get; set; }
        public string DescripcionTBEsta { get; set; }
        public string ComentarioTBEsta { get; set; }
    
        public virtual ICollection<tbMaterial> tbMaterials { get; set; }
    }
}