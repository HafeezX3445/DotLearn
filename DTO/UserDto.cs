using System.ComponentModel.DataAnnotations;

namespace DotLearn.DTO
{
    public class UserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
