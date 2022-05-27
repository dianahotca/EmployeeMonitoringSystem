using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Services;

namespace EmployeeMonitoringApp
{
    public partial class EmployeesAssignedTasksForm : Form
    {
        public MainService Service { get; set; }
        public Employee SelectedEmployee { get; set; }

        public EmployeesAssignedTasksForm(MainService service,Employee selectedEmployee)
        {
            InitializeComponent();
            SelectedEmployee = selectedEmployee;
            Service = service;
        }

        private void EmployeesAssignedTasksForm_Load(object sender, EventArgs e)
        {
            tasksDataGridView.DataSource = Service.GetEmployeeAssignedTasks(SelectedEmployee);
        }
    }
}
