using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class UserDtoCreate
    {

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name max length must be {1} characters")]
        public string Name { get; set; }


        [Required(ErrorMessage = "e-mail is required")]
        [EmailAddress(ErrorMessage = "invalid e-mail")]
        [StringLength(100, ErrorMessage = "e-mail max length must be {1} characters")]
        public string Email { get; set; }
    }
}
