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
    public class ZanimanjeController : BaseReadController<TattooStudio.Model.Zanimanje, object>
    {
        public ZanimanjeController(IReadService<TattooStudio.Model.Zanimanje, object> service)
            :base(service)
        {
        }
    }
}
