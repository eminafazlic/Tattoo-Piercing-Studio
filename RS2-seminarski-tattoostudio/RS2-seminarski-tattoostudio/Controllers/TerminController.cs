using Microsoft.AspNetCore.Mvc;
using RS2_seminarski_tattoostudio.Services;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminController : BaseCRUDController<TattooStudio.Model.Termin, TerminSearchObject, TerminInsertRequest, TerminUpdateRequest>
    {
        public TerminController(ITerminService service)
            :base(service)
        {
        }
    }
}
