using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RS2_seminarski_tattoostudio.Services;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlijentController : BaseCRUDController<TattooStudio.Model.Klijent, KlijentSearchObject, KlijentInsertRequest, KlijentInsertRequest>
    {
        public KlijentController(IKlijentService service)
            :base(service)
        {
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login(UserLoginModel userLogin)
        {
            var user = (_service as IKlijentService).Authenticate(userLogin);
            if (user == null)
            {
                return Unauthorized(new { message = "Pogrešno korisničko ime ili lozinka" });
            }
            return Ok(user);
        }
    }
}
