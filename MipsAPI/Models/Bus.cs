namespace MipsAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Bus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(8)]
        public string NInterno { get; set; }

        public int IdModelo { get; set; }

        public int IdTipoBus { get; set; }

        [Required]
        [MaxLength(8)]
        public string Patente { get; set; }

        [Required]
        public short Anio { get; set; }

        [Required]
        [MaxLength(64)]
        public string Chasis { get; set; }

        [Required]
        public short Plazas { get; set; }

        public int IdCarroceria { get; set; }

        public int IdModeloCarroceria { get; set; }

        public int IdPropiedad { get; set; }

        public int IdPatio { get; set; }

        [Required]
        public bool EnOperacion { get; set; } = true;

        [ForeignKey("IdModelo")]
        public Modelo Modelo { get; set; }

        [ForeignKey("IdTipoBus")]
        public TipoBus TipoBus { get; set; }

        [ForeignKey("IdCarroceria")]
        public Carroceria Carroceria { get; set; }

        [ForeignKey("IdModeloCarroceria")]
        public ModeloCarroceria ModeloCarroceria { get; set; }

        [ForeignKey("IdPropiedad")]
        public Propiedad Propiedad { get; set; }

        [ForeignKey("IdPatio")]
        public Patio Patio { get; set; }
    }
}
