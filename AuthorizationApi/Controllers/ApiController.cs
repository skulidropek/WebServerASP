using AuthorizationApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    public class ApiController : Controller
    {
        public EUserEnter Authorization(string login, string password)
        {
            return Data.HasUser(login, password);
        }
        public EUserAdd Register(string login, string password)
        {
            return Data.AddUser(login, password);
        }
    }
}
