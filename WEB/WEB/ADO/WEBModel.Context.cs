﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WEBContext : DbContext
    {
        public WEBContext()
            : base("name=WEBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbAlumno> tbAlumnoes { get; set; }
        public virtual DbSet<tbCarrera> tbCarreras { get; set; }
        public virtual DbSet<tbCatalogo> tbCatalogoes { get; set; }
        public virtual DbSet<tbCliente> tbClientes { get; set; }
        public virtual DbSet<tbDepartamento> tbDepartamentoes { get; set; }
        public virtual DbSet<tbEstado> tbEstadoes { get; set; }
        public virtual DbSet<tbMaestro> tbMaestroes { get; set; }
        public virtual DbSet<tbMaterial> tbMaterials { get; set; }
        public virtual DbSet<tbNivel> tbNivels { get; set; }
        public virtual DbSet<tbPrestamo> tbPrestamoes { get; set; }
        public virtual DbSet<tbTipoUsuario> tbTipoUsuarios { get; set; }
        public virtual DbSet<tbUsuario> tbUsuarios { get; set; }
        public virtual DbSet<tbMaterialPrestamo> tbMaterialPrestamoes { get; set; }
        public virtual DbSet<tbRegistro> tbRegistroes { get; set; }
    }
}
