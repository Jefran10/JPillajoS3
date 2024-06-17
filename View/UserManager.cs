using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPillajoS3.View
{
    internal class UserManager
    {
        private static List<User> _users = new List<User>();

        public static void AddUser(string username, string password)
        {
            _users.Add(new User { Username = username, Password = password });
        }

        public static bool ValidateCredentials(string username, string password)
        {
            User user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user != null;
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}