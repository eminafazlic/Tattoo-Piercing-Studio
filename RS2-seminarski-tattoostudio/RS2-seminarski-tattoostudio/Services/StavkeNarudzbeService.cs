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
    public class StavkeNarudzbeService : BaseCRUDService<TattooStudio.Model.StavkeNarudzbe, StavkeNarudzbe, StavkeNarudzbeSearchObject, StavkeNarudzbeInsertRequest, StavkeNarudzbeUpdateRequest>, IStavkeNarudzbeService
    {
        public StavkeNarudzbeService(TattooStudioRSIIContext context, IMapper mapper)
            :base(context, mapper)
        {
        }

        public override IList<TattooStudio.Model.StavkeNarudzbe> Get(StavkeNarudzbeSearchObject search = null)
        {
            var entity = _context.Set<StavkeNarudzbe>().AsQueryable();
            if (search?.NarudzbaId.HasValue == true)
            {
                entity = entity.Where(x => x.NarudzbaId == search.NarudzbaId);
            }
            if (search?.ProizvodId.HasValue == true)
            {
                entity = entity.Where(x => x.ProizvodId == search.ProizvodId);
            }
            if (search?.KlijentId.HasValue == true)
            {
                entity = entity.Where(x => x.Narudzba.KlijentId == search.KlijentId);
            }
            var result = entity.Include(x => x.Narudzba).Include(x => x.Narudzba.Klijent).ToList();
            return _mapper.Map<IList<TattooStudio.Model.StavkeNarudzbe>>(result);
        }
    }
}
