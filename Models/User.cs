using System.ComponentModel.DataAnnotations;

namespace Grosary_net.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public string FullName { get; set; }

        public UserRole Role { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}