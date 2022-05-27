using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace EmployeeMonitoringApp
{
    public partial class LogInAsABossForm : Form
    {
        private MainService Service;


        public LogInAsABossForm(MainService service)
        {
            InitializeComponent();
            this.Service = service;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            try
            {
                Service.LogInAsBoss(username,password);
                Hide();
                EmployeeMonitoringForm employeeMonitoringForm=new EmployeeMonitoringForm(Service);
                employeeMonitoringForm.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
