    namespace MipsAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class OpcionEnAuditoria
    {
        [Key]
        [Column(Order = 1)]
        public int IdAuditoria { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdCampoOpcion { get; set; }

        [ForeignKey("IdAuditoria")]
        public Auditoria Auditoria { get; set; }

        [ForeignKey("IdCampoOpcion")]
        public CampoOpcion CampoOpcion { get; set; }
    }
}
