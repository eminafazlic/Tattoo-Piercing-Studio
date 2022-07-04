using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RS2_seminarski_tattoostudio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_seminarski_tattoostudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipProizvodumController : BaseReadController<TattooStudio.Model.TipProizvodum, object>
    {
        public TipProizvodumController(IReadService<TattooStudio.Model.TipProizvodum, object> service)
            :base(service)
        {
        }
    }
}
