namespace EmployeeMonitoringApp
{
    partial class AssignedTasksForm
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
            this.assignedTasksDataGridView = new System.Windows.Forms.DataGridView();
            this.completedButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assignedTasksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // assignedTasksDataGridView
            // 
            this.assignedTasksDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.assignedTasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedTasksDataGridView.Location = new System.Drawing.Point(87, 49);
            this.assignedTasksDataGridView.Name = "assignedTasksDataGridView";
            this.assignedTasksDataGridView.Size = new System.Drawing.Size(633, 180);
            this.assignedTasksDataGridView.TabIndex = 2;
            this.assignedTasksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assignedTasksDataGridView_CellContentClick);
            // 
            // completedButton
            // 
            this.completedButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.completedButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.completedButton.Location = new System.Drawing.Point(302, 332);
            this.completedButton.Name = "completedButton";
            this.completedButton.Size = new System.Drawing.Size(160, 36);
            this.completedButton.TabIndex = 8;
            this.completedButton.Text = "Completed";
            this.completedButton.UseVisualStyleBackColor = false;
            this.completedButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logOutButton.Location = new System.Drawing.Point(716, 402);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(72, 36);
            this.logOutButton.TabIndex = 10;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            // 
            // AssignedTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmployeeMonitoringApp.Properties.Resources.assignment_word_cloud_concept_grey_background_908789261;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.completedButton);
            this.Controls.Add(this.assignedTasksDataGridView);
            this.Name = "AssignedTasksForm";
            this.Text = "AssignedTasks";
            this.Load += new System.EventHandler(this.AssignedTasksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignedTasksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView assignedTasksDataGridView;
        private System.Windows.Forms.Button completedButton;
        private System.Windows.Forms.Button logOutButton;
    }
}