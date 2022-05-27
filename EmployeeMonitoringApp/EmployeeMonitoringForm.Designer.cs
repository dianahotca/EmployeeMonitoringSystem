namespace EmployeeMonitoringApp
{
    partial class EmployeeMonitoringForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.viewAssignedTasksButton = new System.Windows.Forms.Button();
            this.assignTaskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Location = new System.Drawing.Point(132, 75);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(633, 302);
            this.employeesDataGridView.TabIndex = 0;
            this.employeesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(365, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employees ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewAssignedTasksButton
            // 
            this.viewAssignedTasksButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.viewAssignedTasksButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAssignedTasksButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.viewAssignedTasksButton.Location = new System.Drawing.Point(175, 427);
            this.viewAssignedTasksButton.Name = "viewAssignedTasksButton";
            this.viewAssignedTasksButton.Size = new System.Drawing.Size(215, 36);
            this.viewAssignedTasksButton.TabIndex = 6;
            this.viewAssignedTasksButton.Text = "View assigned tasks";
            this.viewAssignedTasksButton.UseVisualStyleBackColor = false;
            this.viewAssignedTasksButton.Click += new System.EventHandler(this.viewAssignedTasksButton_Click);
            // 
            // assignTaskButton
            // 
            this.assignTaskButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.assignTaskButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignTaskButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.assignTaskButton.Location = new System.Drawing.Point(502, 427);
            this.assignTaskButton.Name = "assignTaskButton";
            this.assignTaskButton.Size = new System.Drawing.Size(215, 36);
            this.assignTaskButton.TabIndex = 7;
            this.assignTaskButton.Text = "Assign task";
            this.assignTaskButton.UseVisualStyleBackColor = false;
            this.assignTaskButton.Click += new System.EventHandler(this.assignTaskButton_Click);
            // 
            // EmployeeMonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmployeeMonitoringApp.Properties.Resources.Business_linkedin_cover_Profile_background_Maddyarts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 512);
            this.Controls.Add(this.assignTaskButton);
            this.Controls.Add(this.viewAssignedTasksButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesDataGridView);
            this.Name = "EmployeeMonitoringForm";
            this.Text = "EmployeeMonitoring";
            this.Load += new System.EventHandler(this.EmployeeMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewAssignedTasksButton;
        private System.Windows.Forms.Button assignTaskButton;
    }
}