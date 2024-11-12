    namespace MipsAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class CampoAuditoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdGrupo { get; set; }

        [Required]
        [MaxLength(128)]
        public string Titulo { get; set; }

        [MaxLength(512)]
        public string? Descripcion { get; set; }

        [ForeignKey("IdGrupo")]
        public GrupoCampos GrupoCampos { get; set; }
    }
}
