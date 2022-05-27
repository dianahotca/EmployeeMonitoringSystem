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
    public partial class MainForm : Form
    {
        public MainService Service { get; set; }
        public MainForm(MainService mainService)
        {
            InitializeComponent();
            Service = mainService;
        }

        private void logInAsBossButton_Click(object sender, EventArgs e)
        {
            Hide();
            LogInAsABossForm logInAsABossForm = new LogInAsABossForm(Service);
            logInAsABossForm.Show();
        }

        private void logInAsEmployeeButton_Click(object sender, EventArgs e)
        {
            Hide();
            LogInAsAnEmployeeForm logInAsAnEmployeeForm = new LogInAsAnEmployeeForm(Service);
            logInAsAnEmployeeForm.Show();
        }
    }
}
