﻿namespace AuthorizationApi.Data
{
    public class User
    {
        public string? Login;
        public string? Password;

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
