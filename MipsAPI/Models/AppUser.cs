namespace MipsAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

        public class AppUser
        {
            [Key]
            [MaxLength(128)]
            public string Email { get; set; }

            [MaxLength(128)]
            public string? UserName { get; set; }

            [Required]
            [MaxLength(64)]
            public string Password { get; set; }

            [Required]
            [MaxLength(64)]
            public string PasswordSalt { get; set; }}
    
    
}
