using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RS2_seminarski_tattoostudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Services
{
    public class ObavijestService : BaseCRUDService<TattooStudio.Model.Obavijest, Obavijest, ObavijestSearchObject, ObavijestInsertRequest, ObavijestUpdateRequest>, IObavijestService
    {
        public ObavijestService(TattooStudioRSIIContext context, IMapper mapper)
            :base(context, mapper)
        {
        }

        public override IList<TattooStudio.Model.Obavijest> Get(ObavijestSearchObject search = null)
        {
            var entity = _context.Set<Obavijest>().AsQueryable();
            if (search?.UposlenikId.HasValue == true)
            {
                entity = entity.Where(x => x.UposlenikId == search.UposlenikId);
            }
            var result = entity.OrderByDescending(x => x.Datum).ToList();
            return _mapper.Map<IList<TattooStudio.Model.Obavijest>>(result);
        }
    }
}
