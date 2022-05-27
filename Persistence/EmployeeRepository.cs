using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Model.Task;

namespace Persistence
{
    public class EmployeeRepository
    {
        public void Save(Employee employee)
        {
            using (var context = new EmployeeContext())
            {
                var addedEmployee = context.Employees.Add(employee);
                context.SaveChanges();
            }
        }

        public void CompleteTask(Task task)
        {

        }

        public void LogIn(string username, string password)
        {

            using (var context = new EmployeeContext())
            {
                var userEmployee = FindOne(username);
                if (userEmployee == null || userEmployee.Password!=password)
                {
                    throw new RepositoryException("Username and/or password is incorrect");
                }
                userEmployee.LogInTime = DateTime.Now;
                context.SaveChanges();
            }

        }

        public List<Task> GetAssignedTasks(string username)
        {
            using(var context=new EmployeeContext())
            {
                var assignedTasks = context.TaskEmployees.Where(x => x.Username==username && x.Status==Model.TaskStatus.Assigned).Select(x=>x.Task).ToList();
                return assignedTasks;
            }
        }

        public void MarkEmployeeAssignedTaskAsCompleted(string username, int taskId)
        {
            using (var context = new EmployeeContext())
            {
                var task = context.TaskEmployees.FirstOrDefault(x => x.Username == username && x.TaskId == taskId);
                task.Status = Model.TaskStatus.Completed;
                context.SaveChanges();
            }
        }

        public Employee FindOne(string selectedEmployeeUsername)
        {
            using(var context = new EmployeeContext())
            {
                var employee = context.Employees.FirstOrDefault(x => x.Username == selectedEmployeeUsername);
                return employee;
            }
        }

        public List<Employee> GetAll()
        {
            using (var context = new EmployeeContext())
            {
                return context.Employees.ToList();
            }
        }
    }
}
