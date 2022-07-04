using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace RS2_seminarski_tattoostudio.Services
{
    public interface IUposlenikService : ICRUDService<TattooStudio.Model.Uposlenik, UposlenikSearchObject, UposlenikInsertRequest, UposlenikInsertRequest>
    {
        TattooStudio.Model.Responses.UserAuthenticationResult Authenticate(UserLoginModel userLoginModel);

    }
}
