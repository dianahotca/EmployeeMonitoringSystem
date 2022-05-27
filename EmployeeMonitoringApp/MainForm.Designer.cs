namespace EmployeeMonitoringApp
{
    partial class MainForm
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
            this.logInAsBossButton = new System.Windows.Forms.Button();
            this.logInAsEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logInAsBossButton
            // 
            this.logInAsBossButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.logInAsBossButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInAsBossButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logInAsBossButton.Location = new System.Drawing.Point(300, 141);
            this.logInAsBossButton.Name = "logInAsBossButton";
            this.logInAsBossButton.Size = new System.Drawing.Size(169, 49);
            this.logInAsBossButton.TabIndex = 0;
            this.logInAsBossButton.Text = "Log in as a Boss";
            this.logInAsBossButton.UseVisualStyleBackColor = false;
            this.logInAsBossButton.Click += new System.EventHandler(this.logInAsBossButton_Click);
            // 
            // logInAsEmployeeButton
            // 
            this.logInAsEmployeeButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.logInAsEmployeeButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInAsEmployeeButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logInAsEmployeeButton.Location = new System.Drawing.Point(269, 272);
            this.logInAsEmployeeButton.Name = "logInAsEmployeeButton";
            this.logInAsEmployeeButton.Size = new System.Drawing.Size(227, 49);
            this.logInAsEmployeeButton.TabIndex = 1;
            this.logInAsEmployeeButton.Text = "Log in as an Employee";
            this.logInAsEmployeeButton.UseVisualStyleBackColor = false;
            this.logInAsEmployeeButton.Click += new System.EventHandler(this.logInAsEmployeeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmployeeMonitoringApp.Properties.Resources.compeney_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.logInAsEmployeeButton);
            this.Controls.Add(this.logInAsBossButton);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "EmployeeMonitoringApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logInAsBossButton;
        private System.Windows.Forms.Button logInAsEmployeeButton;
    }
}

