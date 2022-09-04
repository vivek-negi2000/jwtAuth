using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtTokenAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet, Authorize]
        public IEnumerable<string>  Get()
        {
            return new string[]  { "john","Doe","naveen"};
        }
    }
}
