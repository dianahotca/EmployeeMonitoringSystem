using System;
using System.Collections.Generic;

namespace Model
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public TaskStatus Status { get; set; }
        public virtual List<TaskEmployee> SolvingEmployees { get; set; }

        public Task(string name, string description, DateTime dueDate, TaskStatus status)
        {
            Name = name;
            Description = description;
            DueDate = dueDate;
            Status = TaskStatus.Assigned;
            SolvingEmployees = new List<TaskEmployee>();
        }

        public Task() { }

        public void AddSolvingEmployee(Employee employee)
        {
            SolvingEmployees.Add(new TaskEmployee
            {
                Task = this,
                Employee = employee
            });
        }

        public override bool Equals(object obj)
        {
            return obj is Task task &&
                   Id == task.Id &&
                   Name == task.Name &&
                   Description == task.Description &&
                   DueDate == task.DueDate &&
                   Status == task.Status;
        }

        public override int GetHashCode()
        {
            int hashCode = -1235167665;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + DueDate.GetHashCode();
            hashCode = hashCode * -1521134295 + Status.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
