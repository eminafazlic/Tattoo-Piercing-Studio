using AutoMapper;
using RS2_seminarski_tattoostudio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_seminarski_tattoostudio.Services
{
    public class BaseReadService<T, TDb, TSearch> : IReadService<T, TSearch> where T : class where TDb : class where TSearch : class
    {
        protected TattooStudioRSIIContext _context { get; set; }
        protected readonly IMapper _mapper;
        public BaseReadService(TattooStudioRSIIContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual IList<T> Get(TSearch search = null)
        {
            var entity = _context.Set<TDb>();
            var list = entity.ToList();
            return _mapper.Map<IList<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var set = _context.Set<TDb>();
            var entity = set.Find(id);
            return _mapper.Map<T>(entity);
        }
    }
}
