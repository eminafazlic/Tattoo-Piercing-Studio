using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RS2_seminarski_tattoostudio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NarudzbaController : BaseCRUDController<TattooStudio.Model.Narudzba, NarudzbaSearchObject, NarudzbaInsertRequest, NarudzbaInsertRequest>
    {
        public NarudzbaController(INarudzbaService service)
            :base(service)
        {
        }

        [HttpGet("AktivnaNarudzba/{id}")]
        public int AktivnaNarudzba(int id)
        {
            return (_service as INarudzbaService).AktivnaNarudzba(id);
        }

        [HttpGet("SetPaid/{id}")]
        public bool SetPaid(int id)
        {
            return (_service as INarudzbaService).SetPaid(id);
        }
    }
}
