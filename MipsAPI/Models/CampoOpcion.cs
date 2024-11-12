    namespace MipsAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CampoOpcion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdCampoAuditoria { get; set; }

        [Required]
        [MaxLength(128)]
        public string Valor { get; set; }

        [MaxLength(32)]
        public string? Abreviacion { get; set; }

        public int IdNivelAlerta { get; set; }

        [ForeignKey("IdCampoAuditoria")]
        public CampoAuditoria CampoAuditoria { get; set; }

        [ForeignKey("IdNivelAlerta")]
        public NivelAlerta NivelAlerta { get; set; }
    }
}
