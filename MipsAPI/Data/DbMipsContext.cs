using MipsAPI.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace MipsAPI.Data
{
    public class DbMipsContext : DbContext
    {
        public DbMipsContext(DbContextOptions<DbMipsContext> options) : base(options)
        {
        }

        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<UserInGroup> UserInGroups { get; set; }
        public DbSet<Patio> Patios { get; set; }
        public DbSet<Auditor> Auditors { get; set; }
        public DbSet<NivelAlerta> NivelAlertas { get; set; }
        public DbSet<TipoBus> TipoBuses { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Carroceria> Carrocerias { get; set; }
        public DbSet<ModeloCarroceria> ModeloCarrocerias { get; set; }
        public DbSet<Propiedad> Propiedades { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<TipoAuditoria> TipoAuditorias { get; set; }
        public DbSet<UbicacionBus> UbicacionBuses { get; set; }
        public DbSet<EstadoInspeccion> EstadoInspecciones { get; set; }
        public DbSet<Auditoria> Auditorias { get; set; }
        public DbSet<GrupoCampos> GrupoCampos { get; set; }
        public DbSet<CampoAuditoria> CampoAuditorias { get; set; }
        public DbSet<CampoOpcion> CampoOpciones { get; set; }
        public DbSet<OpcionEnAuditoria> OpcionEnAuditorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure composite keys
            modelBuilder.Entity<UserInGroup>()
                .HasKey(uig => new { uig.UserEmail, uig.GroupName });

            modelBuilder.Entity<OpcionEnAuditoria>()
                .HasKey(oea => new { oea.IdAuditoria, oea.IdCampoOpcion });


        }
    }
}

