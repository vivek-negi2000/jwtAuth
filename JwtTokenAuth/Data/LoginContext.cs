using JwtTokenAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtTokenAuth.Data
{
    public class LoginContext :DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options)
            : base(options)
        {

        }
        public DbSet<LoginModel> logins { get; set; }
    }
}
