using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Services
{
    public interface IPortfolioService : ICRUDService<TattooStudio.Model.Portfolio, PortfolioSearchObject, PortfolioInsertRequest, PortfolioInsertRequest>
    {
    }
}
