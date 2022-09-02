using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RS2_seminarski_tattoostudio.Services;
using System;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /*public class KlijentController : BaseCRUDController<TattooStudio.Model.Klijent, KlijentSearchObject, KlijentInsertRequest, KlijentInsertRequest>
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
    }*/
    [Authorize]
    public class KlijentController : ControllerBase
    {
        private readonly IKlijentService _service;
        public KlijentController(IKlijentService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get([FromQuery] KlijentSearchObject request)
        {
            try
            {
                return Ok(_service.Get(request));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Insert(KlijentInsertRequest request)
        {
            try
            {
                return Ok(_service.Insert(request));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, KlijentInsertRequest request)
        {
            try
            {
                return Ok(_service.Update(id, request));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_service.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
