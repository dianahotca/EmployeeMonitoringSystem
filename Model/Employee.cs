using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee : User
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime? LogInTime { get; set; }
        public float Salary { get; set; }
        public virtual List<TaskEmployee> AssignedTasks { get; set; }

        public Employee():base()
        {

        }

        public Employee(string username, string password, string name, string department, float salary) : base(username, password)
        {
            Name = name;
            Department = department;
            LogInTime = null;
            Salary = salary;
            AssignedTasks = new List<TaskEmployee>();
        }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   base.Equals(obj) &&
                   Username == employee.Username &&
                   Password == employee.Password &&
                   Name == employee.Name &&
                   Department == employee.Department &&
                   LogInTime == employee.LogInTime &&
                   Salary == employee.Salary;
        }

        public override int GetHashCode()
        {
            int hashCode = -1058408134;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Department);
            hashCode = hashCode * -1521134295 + LogInTime.GetHashCode();
            hashCode = hashCode * -1521134295 + Salary.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
