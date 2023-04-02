using System.ComponentModel.DataAnnotations;

namespace JwtTokenAuth.Models
{
    public class LoginModel
    {
        [Key]
        public string? UserName { get; set; }
        public string? Password { get; set; }
//added this comment for gitPractice
    }
}
