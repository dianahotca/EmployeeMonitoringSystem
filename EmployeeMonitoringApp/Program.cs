using Model;
using Persistence;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMonitoringApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BossRepository bossRepository = new BossRepository();
            EmployeeRepository employeeRepository = new EmployeeRepository();
            EmployeeService employeeService = new EmployeeService(employeeRepository);
            BossService bossService = new BossService(bossRepository);
            TaskService taskService = new TaskService();
            MainService mainService = new MainService(employeeService, bossService, taskService);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(mainService));
        }
    }
}
