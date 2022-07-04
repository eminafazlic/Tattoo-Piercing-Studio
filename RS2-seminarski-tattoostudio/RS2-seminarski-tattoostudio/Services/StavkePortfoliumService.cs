using AutoMapper;
using RS2_seminarski_tattoostudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Services
{
    public class StavkePortfoliumService : BaseCRUDService<TattooStudio.Model.StavkePortfolium, StavkePortfolium, StavkePortfoliumSearchObject, StavkePortfoliumInsertRequest, StavkePortfoliumInsertRequest>, IStavkePortfoliumService
    {
        public StavkePortfoliumService(TattooStudioRSIIContext context, IMapper mapper)
            :base(context, mapper)
        {

        }

        public override IList<TattooStudio.Model.StavkePortfolium> Get(StavkePortfoliumSearchObject search = null)
        {
            var entity = _context.Set<StavkePortfolium>().AsQueryable();
            if (search?.PortfolioId.HasValue == true)
            {
                entity = entity.Where(x => x.PortfolioId == search.PortfolioId);
            }
            var result = entity.ToList();
            return _mapper.Map<IList<TattooStudio.Model.StavkePortfolium>>(result);
        }
    }
}
