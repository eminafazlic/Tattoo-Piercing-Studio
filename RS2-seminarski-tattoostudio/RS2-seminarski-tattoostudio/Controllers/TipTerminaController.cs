using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RS2_seminarski_tattoostudio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TattooStudio.Model.Requests;

namespace RS2_seminarski_tattoostudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipTerminaController : BaseReadController<TattooStudio.Model.TipTermina, object>
    {
        public TipTerminaController(IReadService<TattooStudio.Model.TipTermina, object> service)
            :base(service)
        {
        }
    }
}
