using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SteamAccountsManager.Serialization
{
    public class Serialization
    {
        public static void Serealize(List<Account> accounts)
        {
            string[] Nicks = new string[accounts.Count];
            string[] Logins = new string[accounts.Count];
            string[] Passwords = new string[accounts.Count];
            for (int i = 0; i < accounts.Count; i++)
            {
                Nicks[i] = accounts[i].Name;
                Logins[i] = accounts[i].Login;
                Passwords[i] = accounts[i].Password;
            }
            string json = JsonSerializer.Serialize(Nicks) + "\n" + JsonSerializer.Serialize(Logins) + "\n" + JsonSerializer.Serialize(Passwords);
            File.WriteAllText(@"C:\Program Files\Steam Account Manager/Accounts.json", json);
        }
        public static List<Account> Deserealize()
        {
            if (File.Exists(@"C:\Program Files\Steam Account Manager/Accounts.json"))
            {
                string file = File.ReadAllText(@"C:\Program Files\Steam Account Manager/Accounts.json");
                string[] da = file.Split('\n');
                string[] Nicks = JsonSerializer.Deserialize<string[]>(da[0]);
                string[] Logins = JsonSerializer.Deserialize<string[]>(da[1]);
                string[] Passwords = JsonSerializer.Deserialize<string[]>(da[2]);
                List<Account> accounts = new List<Account>();
                for (int i = 0; i < Nicks.Length; i++)
                {
                    accounts.Add(new Account(Nicks[i], Logins[i], Passwords[i]));
                }
                return accounts;
            }
            else
                return new List<Account>();
        }
    }
}
