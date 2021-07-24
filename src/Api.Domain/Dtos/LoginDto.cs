using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "e-mail is required")]
        [EmailAddress(ErrorMessage = "invalid e-mail")]
        [StringLength(100, ErrorMessage = "e-mail max length must be {1} characters")]
        public string Email { get; set; }
    }
}
