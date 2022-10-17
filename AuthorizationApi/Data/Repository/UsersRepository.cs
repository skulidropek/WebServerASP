using AuthorizationApi.Domain;

namespace AuthorizationApi.Data.Repository
{
    public class UsersRepository
    {
        private readonly AppDbContent _appDbContent;
        public UsersRepository(AppDbContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<User> Users => _appDbContent.Users;
    }
}
