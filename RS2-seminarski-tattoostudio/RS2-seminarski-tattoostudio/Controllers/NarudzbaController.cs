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
    public class NarudzbaController : BaseCRUDController<TattooStudio.Model.Narudzba, object, NarudzbaInsertRequest, NarudzbaInsertRequest>
    {
        public NarudzbaController(INarudzbaService service)
            :base(service)
        {
        }
    }
}
