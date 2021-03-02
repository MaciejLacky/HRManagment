namespace SystemHR.UserInterface.Forms.Employees
{
    partial class EmployeeFiredForm
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
            this.components = new System.ComponentModel.Container();
            this.lblFiredEmployee = new System.Windows.Forms.Label();
            this.pbEditEmployee = new System.Windows.Forms.PictureBox();
            this.lblWayDeleteContract = new System.Windows.Forms.Label();
            this.lblDateCancelContract = new System.Windows.Forms.Label();
            this.cmbWayDeleteContract = new System.Windows.Forms.ComboBox();
            this.terminationWayModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtbDateDeletContract = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epWayOfFiredEmployee = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDateOfFiredEmployee = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbEditEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationWayModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWayOfFiredEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDateOfFiredEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiredEmployee
            // 
            this.lblFiredEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFiredEmployee.AutoSize = true;
            this.lblFiredEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiredEmployee.Location = new System.Drawing.Point(29, 29);
            this.lblFiredEmployee.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblFiredEmployee.Name = "lblFiredEmployee";
            this.lblFiredEmployee.Size = new System.Drawing.Size(234, 30);
            this.lblFiredEmployee.TabIndex = 1;
            this.lblFiredEmployee.Text = "Imię i Nazwisko - Status";
            // 
            // pbEditEmployee
            // 
            this.pbEditEmployee.Image = global::SystemHR.UserInterface.Properties.Resources.employee_64;
            this.pbEditEmployee.Location = new System.Drawing.Point(400, 12);
            this.pbEditEmployee.Name = "pbEditEmployee";
            this.pbEditEmployee.Size = new System.Drawing.Size(64, 64);
            this.pbEditEmployee.TabIndex = 2;
            this.pbEditEmployee.TabStop = false;
            // 
            // lblWayDeleteContract
            // 
            this.lblWayDeleteContract.AutoSize = true;
            this.lblWayDeleteContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWayDeleteContract.Location = new System.Drawing.Point(31, 133);
            this.lblWayDeleteContract.Name = "lblWayDeleteContract";
            this.lblWayDeleteContract.Size = new System.Drawing.Size(170, 17);
            this.lblWayDeleteContract.TabIndex = 7;
            this.lblWayDeleteContract.Text = "Sposób rozwiązania umowy";
            // 
            // lblDateCancelContract
            // 
            this.lblDateCancelContract.AutoSize = true;
            this.lblDateCancelContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCancelContract.Location = new System.Drawing.Point(31, 176);
            this.lblDateCancelContract.Name = "lblDateCancelContract";
            this.lblDateCancelContract.Size = new System.Drawing.Size(154, 17);
            this.lblDateCancelContract.TabIndex = 8;
            this.lblDateCancelContract.Text = "Data zakończenia umowy";
            // 
            // cmbWayDeleteContract
            // 
            this.cmbWayDeleteContract.DataSource = this.terminationWayModelBindingSource;
            this.cmbWayDeleteContract.DisplayMember = "Value";
            this.cmbWayDeleteContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWayDeleteContract.FormattingEnabled = true;
            this.cmbWayDeleteContract.Location = new System.Drawing.Point(299, 125);
            this.cmbWayDeleteContract.Name = "cmbWayDeleteContract";
            this.cmbWayDeleteContract.Size = new System.Drawing.Size(165, 25);
            this.cmbWayDeleteContract.TabIndex = 9;
            this.cmbWayDeleteContract.ValueMember = "Id";
            this.cmbWayDeleteContract.SelectedIndexChanged += new System.EventHandler(this.cmbWayDeleteContract_SelectedIndexChanged);
            this.cmbWayDeleteContract.TextChanged += new System.EventHandler(this.cmbWayDeleteContract_TextChanged);
            // 
            // terminationWayModelBindingSource
            // 
            this.terminationWayModelBindingSource.DataSource = typeof(SystemHR.DataAccessLayer.Models.Dictionaries.TerminationWayModel);
            // 
            // dtbDateDeletContract
            // 
            this.dtbDateDeletContract.Checked = false;
            this.dtbDateDeletContract.CustomFormat = " ";
            this.dtbDateDeletContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtbDateDeletContract.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbDateDeletContract.Location = new System.Drawing.Point(299, 168);
            this.dtbDateDeletContract.Name = "dtbDateDeletContract";
            this.dtbDateDeletContract.Size = new System.Drawing.Size(165, 25);
            this.dtbDateDeletContract.TabIndex = 10;
            this.dtbDateDeletContract.ValueChanged += new System.EventHandler(this.dtbDateDeletContract_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(343, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Image = global::SystemHR.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(217, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epWayOfFiredEmployee
            // 
            this.epWayOfFiredEmployee.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epWayOfFiredEmployee.ContainerControl = this;
            // 
            // epDateOfFiredEmployee
            // 
            this.epDateOfFiredEmployee.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epDateOfFiredEmployee.ContainerControl = this;
            // 
            // EmployeeFiredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtbDateDeletContract);
            this.Controls.Add(this.cmbWayDeleteContract);
            this.Controls.Add(this.lblDateCancelContract);
            this.Controls.Add(this.lblWayDeleteContract);
            this.Controls.Add(this.pbEditEmployee);
            this.Controls.Add(this.lblFiredEmployee);
            this.Name = "EmployeeFiredForm";
            this.Text = "Zwolnij pracownika";
            ((System.ComponentModel.ISupportInitialize)(this.pbEditEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationWayModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWayOfFiredEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDateOfFiredEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiredEmployee;
        private System.Windows.Forms.PictureBox pbEditEmployee;
        private System.Windows.Forms.Label lblWayDeleteContract;
        private System.Windows.Forms.Label lblDateCancelContract;
        private System.Windows.Forms.ComboBox cmbWayDeleteContract;
        private System.Windows.Forms.DateTimePicker dtbDateDeletContract;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epWayOfFiredEmployee;
        private System.Windows.Forms.ErrorProvider epDateOfFiredEmployee;
        private System.Windows.Forms.BindingSource terminationWayModelBindingSource;
    }
}