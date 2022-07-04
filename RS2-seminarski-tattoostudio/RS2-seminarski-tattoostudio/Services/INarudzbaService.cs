using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TattooStudio.Model.Requests;

namespace RS2_seminarski_tattoostudio.Services
{
    public interface INarudzbaService : ICRUDService<TattooStudio.Model.Narudzba, object, NarudzbaInsertRequest, NarudzbaInsertRequest>
    {
        public bool SetPaid(int id);
    }
}
