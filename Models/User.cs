using System.ComponentModel.DataAnnotations;

namespace DotLearn.Models
{
    public class User
    {
        //this
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
