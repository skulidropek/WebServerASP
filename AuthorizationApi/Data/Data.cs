using Newtonsoft.Json;

namespace AuthorizationApi.Data
{
    public static class Data
    {
        private static List<User>? _users = new List<User>();
        public static EUserEnter HasUser(string login, string password)
        {
            if (!HasLogin(login)) return EUserEnter.LoginNotHave;
            if(!HasPassword(password)) return EUserEnter.PasswordNotHave;
            return EUserEnter.Enter;
        }
        private static bool HasLogin(string login)
        {
            return _users.Any(x => x.Login == login);
        }
        private static bool HasPassword(string password)
        {
            return _users.Any(x => x.Password == password);
        }
        public static EUserAdd AddUser(string login, string password)
        {
            if (HasLogin(login))
                return EUserAdd.LoginExists;

            _users.Add(new User(login, password));
            return EUserAdd.UserCreated;
        }
        public static void Save()
        {
            File.WriteAllText("Users", JsonConvert.SerializeObject(_users));
        }
        public static void Load()
        {
            _users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("Users"));
        }
    }
}
