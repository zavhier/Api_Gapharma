﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gapharma_models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gapharmaEntities : DbContext
    {
        public gapharmaEntities()
            : base("name=gapharmaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CABECERA_DOCUMENTO> CABECERA_DOCUMENTO { get; set; }
        public virtual DbSet<CLIENTE> CLIENTEs { get; set; }
        public virtual DbSet<DESTINATARIO> DESTINATARIOs { get; set; }
        public virtual DbSet<DETALLE_DOCUMENTO> DETALLE_DOCUMENTO { get; set; }
        public virtual DbSet<EMPLEADO> EMPLEADOes { get; set; }
        public virtual DbSet<EMPRESA> EMPRESAs { get; set; }
        public virtual DbSet<ESTADO> ESTADOes { get; set; }
        public virtual DbSet<HOJA_DE_RUTA> HOJA_DE_RUTA { get; set; }
        public virtual DbSet<LUGAR_DE_ENTREGA> LUGAR_DE_ENTREGA { get; set; }
        public virtual DbSet<MARCA_MODELO> MARCA_MODELO { get; set; }
        public virtual DbSet<PAQUETE> PAQUETEs { get; set; }
        public virtual DbSet<PERMISO> PERMISOes { get; set; }
        public virtual DbSet<PERSONA> PERSONAs { get; set; }
        public virtual DbSet<RUTA> RUTAs { get; set; }
        public virtual DbSet<SERVICIO> SERVICIOs { get; set; }
        public virtual DbSet<TIPO_DOCUMENTO> TIPO_DOCUMENTO { get; set; }
        public virtual DbSet<TIPO_VEHICULO> TIPO_VEHICULO { get; set; }
        public virtual DbSet<TRANSPORTISTA> TRANSPORTISTAs { get; set; }
        public virtual DbSet<USUARIO> USUARIOs { get; set; }
        public virtual DbSet<VEHICULO> VEHICULOes { get; set; }
        public virtual DbSet<BITACORA> BITACORAs { get; set; }
        public virtual DbSet<CLIENTE_DESTINATARIO> CLIENTE_DESTINATARIO { get; set; }
        public virtual DbSet<PERMISO_USUARIO> PERMISO_USUARIO { get; set; }
        public virtual DbSet<TIPO_DE_CARGA> TIPO_DE_CARGA { get; set; }
        public virtual DbSet<TIPO_RUTA> TIPO_RUTA { get; set; }
        public virtual DbSet<ZONA> ZONAS { get; set; }
    }
}
