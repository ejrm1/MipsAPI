namespace MipsAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserGroup
    {
        [Key]
        [MaxLength(128)]
        public string Name { get; set; }
    }
}
