namespace SteamAccountsManager
{
    public class Account
    {
        public string Name;
        public string Login;
        public string Password;
        public Account(string a, string b, string c)
        {
            Name = a;
            Login = b;
            Password = c;
        }
    }
}