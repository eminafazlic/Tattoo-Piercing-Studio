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
    public class ProizvodController : BaseCRUDController<TattooStudio.Model.Proizvod, ProizvodSearchObject, ProizvodInsertRequest, ProizvodInsertRequest>
    {
        public ProizvodController(IProizvodService service)
            :base(service)
        {
        }

        [HttpGet("Recommend/{id}")]
        public List<TattooStudio.Model.Proizvod> Recommend(int id)
        {
            return (_service as IProizvodService).Recommend(id);
        }
    }
}
