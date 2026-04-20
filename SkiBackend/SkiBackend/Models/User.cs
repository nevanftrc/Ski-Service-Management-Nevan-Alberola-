using System.ComponentModel.DataAnnotations;

namespace SkiBackend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Passwort { get; set; }
    }
}
