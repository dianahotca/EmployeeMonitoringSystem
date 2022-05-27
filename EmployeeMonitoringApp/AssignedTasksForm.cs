using Model;
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
using Task = Model.Task;

namespace EmployeeMonitoringApp
{
    public partial class AssignedTasksForm : Form
    {
        public MainService Service { get; set; }
        public Employee LoggedEmployee { get; set; }

        private int? SelectedTaskId { get; set; }

        private BindingSource tasksBindingSource = new BindingSource();
        private List<Task> assignedTasks { get; set; }

        public AssignedTasksForm(MainService service,Employee loggedEmployee)
        {
            Service = service;
            LoggedEmployee = loggedEmployee;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectedTaskId == null)
            {
                MessageBox.Show("Please select a task!");
            }
            else
            {
                Service.ConfirmTaskExecution(LoggedEmployee, (int)SelectedTaskId);
                DisplayTasks();
            }
        }

        private void AssignedTasksForm_Load(object sender, EventArgs e)
        {
            assignedTasks= Service.GetEmployeeAssignedTasks(LoggedEmployee);
            tasksBindingSource.DataSource = assignedTasks;
            assignedTasksDataGridView.DataSource = tasksBindingSource;
            DisplayTasks();
        }

        private void DisplayTasks()
        {
            assignedTasks = Service.GetEmployeeAssignedTasks(LoggedEmployee);
            tasksBindingSource.DataSource=assignedTasks;
            assignedTasksDataGridView.DataSource = null;
            assignedTasksDataGridView.DataSource = tasksBindingSource;
            assignedTasksDataGridView.Refresh();
            assignedTasksDataGridView.Update();
        }

        private void assignedTasksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRowIndex = assignedTasksDataGridView.CurrentCell.RowIndex;
            var selectedRow = assignedTasksDataGridView.Rows[selectedRowIndex];
            var taskIdCell = selectedRow.Cells[0];
            SelectedTaskId = (int)taskIdCell.Value;
        }
    }
}
