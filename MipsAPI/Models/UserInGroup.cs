namespace MipsAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserInGroup
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(128)]
        public string UserEmail { get; set; }

        [Key]
        [Column(Order = 2)]
        [MaxLength(128)]
        public string GroupName { get; set; }

        [ForeignKey("UserEmail")]
        public AppUser AppUser { get; set; }

        [ForeignKey("GroupName")]
        public UserGroup UserGroup { get; set; }
    }
}
