using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RS2_seminarski_tattoostudio.Database;
using RS2_seminarski_tattoostudio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_seminarski_tattoostudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpolController : BaseReadController<TattooStudio.Model.Spol, object>
    {
        public SpolController(IReadService<TattooStudio.Model.Spol, object> service)
            :base(service)
        {
        }
    }
}
