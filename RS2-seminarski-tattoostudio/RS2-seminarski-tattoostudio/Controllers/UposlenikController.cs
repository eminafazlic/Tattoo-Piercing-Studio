using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RS2_seminarski_tattoostudio.Services;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UposlenikController : BaseCRUDController<TattooStudio.Model.Uposlenik, UposlenikSearchObject, UposlenikInsertRequest, UposlenikInsertRequest>
    {
        public UposlenikController(IUposlenikService service)
            :base(service)
        {
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login(UserLoginModel userLogin)
        {
            var user = (_service as IUposlenikService).Authenticate(userLogin);
            if (user == null)
            {
                return Unauthorized(new { message = "Pogrešno korisničko ime ili lozinka" });
            }
            return Ok(user);
        }
    }
}
