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
    public partial class LogInAsAnEmployeeForm : Form
    {
        private MainService Service;

        public LogInAsAnEmployeeForm(MainService service)
        {
            InitializeComponent();

            this.Service = service;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            try
            {
                Service.LogInAsEmployee(username,password);
                AssignedTasksForm assignedTasksForm = new AssignedTasksForm(Service,Service.FindEmployee(username));
                Hide();
                assignedTasksForm.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
