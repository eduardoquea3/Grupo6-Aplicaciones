﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinalUsuarioAdmin.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProyectoFinalEntities2 : DbContext
    {
        public ProyectoFinalEntities2()
            : base("name=ProyectoFinalEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<DatosAcademicos> DatosAcademicos { get; set; }
        public virtual DbSet<Discapacidad> Discapacidad { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<Experencias> Experencias { get; set; }
        public virtual DbSet<Sexo> Sexo { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<Ubigeo> Ubigeo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioAdmin> UsuarioAdmin { get; set; }
        public virtual DbSet<UsuarioDocente> UsuarioDocente { get; set; }
        public virtual DbSet<RegistroDocente> RegistroDocente { get; set; }
    }
}