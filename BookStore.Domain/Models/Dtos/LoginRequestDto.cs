using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Models.Dtos
{
    public class LoginRequestDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
