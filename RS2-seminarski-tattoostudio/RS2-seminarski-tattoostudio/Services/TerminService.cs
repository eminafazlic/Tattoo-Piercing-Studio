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
    public class TerminService : BaseCRUDService<TattooStudio.Model.Termin, Termin, TerminSearchObject, TerminInsertRequest, TerminUpdateRequest>, ITerminService
    {
        public TerminService(TattooStudioRSIIContext context, IMapper mapper)
            :base(context, mapper)
        {
        }

        public override IList<TattooStudio.Model.Termin> Get(TerminSearchObject search = null)
        {
            var entity = _context.Set<Termin>().AsQueryable();
            if(search?.IsOdobren == false)
            {
                entity = entity.Where(x => x.IsOdobren == search.IsOdobren);
            }
            if (search?.IsPlacen == true)
            {
                entity = entity.Where(x => x.IsPlacen == search.IsPlacen);
            }
            if (search?.IsOtkazan == true)
            {
                entity = entity.Where(x => x.IsOtkazan == search.IsOtkazan);
            }
            if (search?.Datum != null)
            {
                entity = entity.Where(x => x.Datum == search.Datum);
            }
            if (search?.UposlenikId.HasValue == true)
            {
                entity = entity.Where(x => x.UposlenikId == search.UposlenikId);
            }
            if (search?.KlijentId.HasValue == true)
            {
                entity = entity.Where(x => x.KlijentId == search.KlijentId);
            }
            if (search?.NadolazeciTermini == true)
            {
                entity = entity.Where(x => x.Datum > DateTime.Now);
            }
            var result = entity.Include(x => x.Klijent)
                .Include(x => x.Uposlenik)
                .Include(x => x.TipTermina)
                .OrderBy(x => x.Datum).ToList();
            return _mapper.Map<IList<TattooStudio.Model.Termin>>(result);
        }

        public override TattooStudio.Model.Termin GetById(int id)
        {
            var entity = _context.Termins.Include(x => x.Klijent)
                .Include(x => x.TipTermina)
                .Where(x => x.TerminId == id)
                .FirstOrDefaultAsync();
            return _mapper.Map<TattooStudio.Model.Termin>(entity);
        }


        public bool SetPaid(int id)
        {
            var entity = _context.Termins.Find(id);
            entity.IsPlacen = true;
            _context.SaveChanges();
            return true;
        }

    }
}
