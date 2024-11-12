    namespace MipsAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Auditoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime MarcaTemporal { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        public int IdPatio { get; set; }

        public int IdTipoAuditoria { get; set; }

        public int IdAuditor { get; set; }

        public int IdUbicacionBus { get; set; }

        public int IdEstadoInspeccion { get; set; }

        [ForeignKey("IdPatio")]
        public Patio Patio { get; set; }

        [ForeignKey("IdTipoAuditoria")]
        public TipoAuditoria TipoAuditoria { get; set; }

        [ForeignKey("IdAuditor")]
        public Auditor Auditor { get; set; }

        [ForeignKey("IdUbicacionBus")]
        public UbicacionBus UbicacionBus { get; set; }

        [ForeignKey("IdEstadoInspeccion")]
        public EstadoInspeccion EstadoInspeccion { get; set; }
    }
}
