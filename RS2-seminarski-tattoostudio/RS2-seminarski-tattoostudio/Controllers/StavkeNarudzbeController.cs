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
    public class StavkeNarudzbeController : BaseCRUDController<TattooStudio.Model.StavkeNarudzbe, StavkeNarudzbeSearchObject, StavkeNarudzbeInsertRequest, StavkeNarudzbeUpdateRequest>
    {
        public StavkeNarudzbeController(IStavkeNarudzbeService service)
            :base(service)
        {
        }
    }
}
