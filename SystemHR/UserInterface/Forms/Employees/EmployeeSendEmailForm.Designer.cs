namespace SystemHR.UserInterface.Forms.Employees
{
    partial class EmployeeSendEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSendEmailForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.pbSendEmailEmployee = new System.Windows.Forms.PictureBox();
            this.lblReceiverEmailEmployee = new System.Windows.Forms.Label();
            this.lblSenderEmailEmployee = new System.Windows.Forms.Label();
            this.lblThemeEmailEmployee = new System.Windows.Forms.Label();
            this.lblTextEmailEmployee = new System.Windows.Forms.Label();
            this.txtReceiverEmailEmployee = new System.Windows.Forms.TextBox();
            this.tbSenderEmailEmployee = new System.Windows.Forms.TextBox();
            this.tbThemeSendEmployee = new System.Windows.Forms.TextBox();
            this.tbTextSendEmployee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSendEmailEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Image = global::SystemHR.UserInterface.Properties.Resources.email_24;
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pbSendEmailEmployee
            // 
            this.pbSendEmailEmployee.Image = global::SystemHR.UserInterface.Properties.Resources.email__1_;
            resources.ApplyResources(this.pbSendEmailEmployee, "pbSendEmailEmployee");
            this.pbSendEmailEmployee.Name = "pbSendEmailEmployee";
            this.pbSendEmailEmployee.TabStop = false;
            // 
            // lblReceiverEmailEmployee
            // 
            resources.ApplyResources(this.lblReceiverEmailEmployee, "lblReceiverEmailEmployee");
            this.lblReceiverEmailEmployee.Name = "lblReceiverEmailEmployee";
            // 
            // lblSenderEmailEmployee
            // 
            resources.ApplyResources(this.lblSenderEmailEmployee, "lblSenderEmailEmployee");
            this.lblSenderEmailEmployee.Name = "lblSenderEmailEmployee";
            // 
            // lblThemeEmailEmployee
            // 
            resources.ApplyResources(this.lblThemeEmailEmployee, "lblThemeEmailEmployee");
            this.lblThemeEmailEmployee.Name = "lblThemeEmailEmployee";
            // 
            // lblTextEmailEmployee
            // 
            resources.ApplyResources(this.lblTextEmailEmployee, "lblTextEmailEmployee");
            this.lblTextEmailEmployee.Name = "lblTextEmailEmployee";
            // 
            // txtReceiverEmailEmployee
            // 
            resources.ApplyResources(this.txtReceiverEmailEmployee, "txtReceiverEmailEmployee");
            this.txtReceiverEmailEmployee.Name = "txtReceiverEmailEmployee";
            // 
            // tbSenderEmailEmployee
            // 
            resources.ApplyResources(this.tbSenderEmailEmployee, "tbSenderEmailEmployee");
            this.tbSenderEmailEmployee.Name = "tbSenderEmailEmployee";
            // 
            // tbThemeSendEmployee
            // 
            resources.ApplyResources(this.tbThemeSendEmployee, "tbThemeSendEmployee");
            this.tbThemeSendEmployee.Name = "tbThemeSendEmployee";
            // 
            // tbTextSendEmployee
            // 
            resources.ApplyResources(this.tbTextSendEmployee, "tbTextSendEmployee");
            this.tbTextSendEmployee.Name = "tbTextSendEmployee";
            // 
            // EmployeeSendEmailForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbTextSendEmployee);
            this.Controls.Add(this.tbThemeSendEmployee);
            this.Controls.Add(this.tbSenderEmailEmployee);
            this.Controls.Add(this.txtReceiverEmailEmployee);
            this.Controls.Add(this.lblTextEmailEmployee);
            this.Controls.Add(this.lblThemeEmailEmployee);
            this.Controls.Add(this.lblSenderEmailEmployee);
            this.Controls.Add(this.lblReceiverEmailEmployee);
            this.Controls.Add(this.pbSendEmailEmployee);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Name = "EmployeeSendEmailForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbSendEmailEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox pbSendEmailEmployee;
        private System.Windows.Forms.Label lblReceiverEmailEmployee;
        private System.Windows.Forms.Label lblSenderEmailEmployee;
        private System.Windows.Forms.Label lblThemeEmailEmployee;
        private System.Windows.Forms.Label lblTextEmailEmployee;
        private System.Windows.Forms.TextBox txtReceiverEmailEmployee;
        private System.Windows.Forms.TextBox tbSenderEmailEmployee;
        private System.Windows.Forms.TextBox tbThemeSendEmployee;
        private System.Windows.Forms.TextBox tbTextSendEmployee;
    }
}