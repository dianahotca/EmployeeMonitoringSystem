using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Boss : User
    {
        public string Name { get; set; }

        public Boss():base()
        {

        }

        public Boss(string username, string password, string name) : base(username, password)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return obj is Boss boss &&
                   base.Equals(obj) &&
                   Username == boss.Username &&
                   Password == boss.Password &&
                   Name == boss.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = 404091357;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
