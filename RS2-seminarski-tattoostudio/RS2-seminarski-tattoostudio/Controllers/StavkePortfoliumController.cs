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
    public class StavkePortfoliumController : BaseCRUDController<TattooStudio.Model.StavkePortfolium, StavkePortfoliumSearchObject, StavkePortfoliumInsertRequest, StavkePortfoliumInsertRequest>
    {
        public StavkePortfoliumController(IStavkePortfoliumService service)
            :base(service)
        {
        }
    }
}
