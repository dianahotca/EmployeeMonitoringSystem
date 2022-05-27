using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public User() { }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Username == user.Username &&
                   Password == user.Password;
        }

        public override int GetHashCode()
        {
            int hashCode = -1032222642;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
