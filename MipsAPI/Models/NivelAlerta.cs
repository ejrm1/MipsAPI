namespace MipsAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class NivelAlerta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Alerta { get; set; }

        [Required]
        [MaxLength(12)]
        public string ColorHex { get; set; }

        [Required]
        public short Prioridad { get; set; }
    }
}
