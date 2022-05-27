using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeService
    {
        public EmployeeRepository EmployeeRepository { get; private set; }

        public EmployeeService(EmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository;
        }


        public void LogIn(string username, string password)
        {
            EmployeeRepository.LogIn(username, password);
        }

        public List<Employee> GetAll()
        {
            return EmployeeRepository.GetAll();
        }

        internal Employee FindOne(string selectedEmployeeUsername)
        {
            return EmployeeRepository.FindOne(selectedEmployeeUsername);
        }

        internal List<Model.Task> GetAssignedTasks(Employee selectedEmployee)
        {
            return EmployeeRepository.GetAssignedTasks(selectedEmployee.Username);
        }

        internal void ConfrimTaskExecution(Employee loggedEmployee, int selectedTaskId)
        {
            EmployeeRepository.MarkEmployeeAssignedTaskAsCompleted(loggedEmployee.Username, selectedTaskId);
        }
    }
}
