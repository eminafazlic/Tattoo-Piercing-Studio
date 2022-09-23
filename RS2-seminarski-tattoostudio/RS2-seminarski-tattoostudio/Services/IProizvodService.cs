using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Services
{
    public interface IProizvodService : ICRUDService<TattooStudio.Model.Proizvod, ProizvodSearchObject, ProizvodInsertRequest, ProizvodInsertRequest>
    {
        public List<TattooStudio.Model.Proizvod> Recommend(int id);
        public int BrojProdanih(int id);

    }
}
