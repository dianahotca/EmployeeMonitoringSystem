using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task = Model.Task;

namespace Persistence
{
    public class TaskRepository
    {
        void Add(Task task)
        {
            using(var context = new EmployeeContext())
            {
                context.Tasks.Add(task);
                context.SaveChanges();
            }
        }
        void Delete(Task task)
        {
            using (var context = new EmployeeContext())
            {
                // var task = context.Tasks.FirstOrDefault(x=>x.Id == task.Id);
                context.Tasks.Remove(task);
                context.SaveChanges();
            }
        }
        void Update(Task task, Employee oldEmployee, Employee newEmployee)
        {
            using (var context = new EmployeeContext())
            {
                var taskEmployee = context.TaskEmployees.FirstOrDefault(x=>x.TaskId == task.Id && x.Username == oldEmployee.Username);
                taskEmployee.Username = newEmployee.Username;
                context.SaveChanges();

                /*oldEmployee.AssignedTasks = oldEmployee.AssignedTasks.Where(x => x.TaskId != task.Id).ToList();*/
            }
        }
    }
}
