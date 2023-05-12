using System.ComponentModel.DataAnnotations;

namespace SpaceX.Models.DTO.User
{
    public class UserLogin
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
