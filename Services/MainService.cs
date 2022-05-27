using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Model.Task;

namespace Services
{
    public class MainService
    {
        public EmployeeService EmployeeService { get; set; }
        public BossService BossService { get; set; }
        public TaskService TaskService { get; set; }

        public MainService(EmployeeService employeeService, BossService bossService, TaskService taskService)
        {
            EmployeeService = employeeService;
            BossService = bossService;
            TaskService = taskService;
        }

        public void LogInAsBoss(string username, string password)
        {
            BossService.LogIn(username, password);
        }

        public void LogInAsEmployee(string username, string password)
        {
            EmployeeService.LogIn(username, password);
        }

        public void ConfirmTaskExecution(Employee loggedEmployee, int selectedTaskId)
        {
            EmployeeService.ConfrimTaskExecution(loggedEmployee, selectedTaskId);
        }

        public List<Task> GetEmployeeAssignedTasks(Employee selectedEmployee)
        {
            return EmployeeService.GetAssignedTasks(selectedEmployee);
        }

        public List<Employee> GetAllEmployees()
        {
            return EmployeeService.GetAll();
        }

        public Employee FindEmployee(string selectedEmployeeUsername)
        {
            return EmployeeService.FindOne(selectedEmployeeUsername);
        }
    }
}
