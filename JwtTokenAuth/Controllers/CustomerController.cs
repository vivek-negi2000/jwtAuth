using JwtTokenAuth.Data;
using JwtTokenAuth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtTokenAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CustomerController : ControllerBase
    {
        private readonly LoginContext _db;

        public CustomerController(LoginContext db)
        {
            _db = db;
        }

        [HttpGet, Authorize]
        public IEnumerable<string>  Get()
        {
            return new string[]  { "john","Doe","naveen"};
        }

        [HttpGet("Logged-Users"), Authorize]
        public IEnumerable<LoginModel> Details()
        {
            return _db.logins.ToList();
        }

        [HttpGet("GetLoginModelData")]
        public LoginModel GetLoginModelData()
        {
            try
            {
                // Model object creation.
                LoginModel objLoginModel = new LoginModel();

                // data filling into the object.
                objLoginModel.UserName = "Vivek sir";
                objLoginModel.Password = "123456";

                //data return
                return objLoginModel;
            }
            catch(Exception)
            {
                throw ;
            }
           
        }
    }

    
}
