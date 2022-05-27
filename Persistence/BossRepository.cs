using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task = Model.Task;

namespace Persistence
{
    public class BossRepository
    {
        public void LogIn(string username, string password)
        {
            using (var context = new EmployeeContext())
            {
                var userBoss = FindOne(username);
                
                if (userBoss == null || userBoss.Password!=password)
                {
                    throw new RepositoryException("Username and/or password is incorrect");
                }
            }
        }

        public void Save(Boss boss)
        {
            using(var context = new EmployeeContext())
            {
                context.Bosses.Add(boss);
                context.SaveChanges();
            }
        }

        public Boss FindOne(string username)
        {
            using (var context = new EmployeeContext())
            {
                return context.Bosses.FirstOrDefault(b => b.Username == username);
            }
        }
    }
}
