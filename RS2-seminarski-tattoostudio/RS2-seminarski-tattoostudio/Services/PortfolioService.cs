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
    public class PortfolioService : BaseCRUDService<TattooStudio.Model.Portfolio, Portfolio, PortfolioSearchObject, PortfolioInsertRequest, PortfolioInsertRequest>, IPortfolioService
    {
        public PortfolioService(TattooStudioRSIIContext context, IMapper mapper)
            :base(context, mapper)
        {
        }

        public override IList<TattooStudio.Model.Portfolio> Get(PortfolioSearchObject search = null)
        {
            var entity = _context.Set<Portfolio>().AsQueryable();
            if (search?.UposlenikId.HasValue == true)
            {
                entity = entity.Where(x => x.UposlenikId == search.UposlenikId);
            }
            var result = entity.Include(x => x.Uposlenik).ToList();
            return _mapper.Map<IList<TattooStudio.Model.Portfolio>>(result);
        }
        public override bool Delete(int id)
        {
            if (id != 0)
            {
                var stavkePortfolia = _context.StavkePortfolia.Where(x => x.PortfolioId == id).ToList();
                foreach(var x in stavkePortfolia)
                {
                    _context.Remove(x);
                }
                _context.SaveChanges();
                var portfolio = _context.Portfolios.Find(id);
                _context.Remove(portfolio);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
