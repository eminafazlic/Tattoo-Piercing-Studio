using System.Collections.Generic;
using System.Threading.Tasks;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Services
{
    public interface IKlijentService : ICRUDService<TattooStudio.Model.Klijent, KlijentSearchObject, KlijentInsertRequest, KlijentInsertRequest>
    {
        TattooStudio.Model.Responses.UserAuthenticationResult Authenticate(UserLoginModel userLoginModel);
    }
}
