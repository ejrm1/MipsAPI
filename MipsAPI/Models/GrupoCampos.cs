    namespace MipsAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class GrupoCampos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdGrupoPadre { get; set; }

        [Required]
        [MaxLength(64)]
        public string Nombre { get; set; }

        [ForeignKey("IdGrupoPadre")]
        public GrupoCampos GrupoCamposPadre { get; set; }
    }

}
