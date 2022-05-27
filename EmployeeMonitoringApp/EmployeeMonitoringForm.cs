using Model;
using Persistence;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMonitoringApp
{
    public partial class EmployeeMonitoringForm : Form
    {
        public MainService Service { get; set; }
        private Employee SelectedEmployee;


        public EmployeeMonitoringForm(MainService service)
        {
            InitializeComponent();
            this.Service = service;
            SelectedEmployee = null;
        }

        private void viewAssignedTasksButton_Click(object sender, EventArgs e)
        {
            if (SelectedEmployee == null)
            {
                MessageBox.Show("Please select an employee!");
            }
            else
            {
                EmployeesAssignedTasksForm employeesAssignedTasksForm = new EmployeesAssignedTasksForm(Service, SelectedEmployee);
                employeesAssignedTasksForm.Show();
            }
        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = employeesDataGridView.CurrentCell.RowIndex;
            var selectedRow=employeesDataGridView.Rows[selectedRowIndex];
            var usernameCell = selectedRow.Cells[4];
            string selectedEmployeeUsername = usernameCell.Value.ToString();
            SelectedEmployee = Service.FindEmployee(selectedEmployeeUsername);
        }

        private void EmployeeMonitoring_Load(object sender, EventArgs e)
        {

            employeesDataGridView.DataSource = Service.GetAllEmployees();
            DisplayEmployees();
        }

        private void DisplayEmployees()
        {
            employeesDataGridView.Refresh();
        }

        private void assignTaskButton_Click(object sender, EventArgs e)
        {
            AssignTaskForm assignTaskForm = new AssignTaskForm();
        }
    }
}
