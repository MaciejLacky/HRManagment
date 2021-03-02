namespace SystemHR.UserInterface.Forms.Departments
{
    partial class DepartmentAddForm
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
            this.pbAddDepartment = new System.Windows.Forms.PictureBox();
            this.lblAddDepartment = new System.Windows.Forms.Label();
            this.lblNameAddPosition = new System.Windows.Forms.Label();
            this.lblLocationAddDepartment = new System.Windows.Forms.Label();
            this.lblManagerAddDepartment = new System.Windows.Forms.Label();
            this.lnlNameAddDepartemnt = new System.Windows.Forms.Label();
            this.tbAddNameDepartment = new System.Windows.Forms.TextBox();
            this.tbManagerAddDepartment = new System.Windows.Forms.TextBox();
            this.tbLocationAddDepartment = new System.Windows.Forms.TextBox();
            this.tbDepartmentAdd = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epNameDepartment = new System.Windows.Forms.ErrorProvider(this.components);
            this.epManagerDepartment = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMainDepartment = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddEmployeeDepartment = new System.Windows.Forms.Button();
            this.btnAddMainDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNameDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epManagerDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMainDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAddDepartment
            // 
            this.pbAddDepartment.Image = global::SystemHR.UserInterface.Properties.Resources.Departments_32;
            this.pbAddDepartment.Location = new System.Drawing.Point(408, 12);
            this.pbAddDepartment.Name = "pbAddDepartment";
            this.pbAddDepartment.Size = new System.Drawing.Size(64, 64);
            this.pbAddDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddDepartment.TabIndex = 5;
            this.pbAddDepartment.TabStop = false;
            // 
            // lblAddDepartment
            // 
            this.lblAddDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddDepartment.AutoSize = true;
            this.lblAddDepartment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDepartment.Location = new System.Drawing.Point(16, 34);
            this.lblAddDepartment.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblAddDepartment.Name = "lblAddDepartment";
            this.lblAddDepartment.Size = new System.Drawing.Size(60, 30);
            this.lblAddDepartment.TabIndex = 4;
            this.lblAddDepartment.Text = "Dział";
            // 
            // lblNameAddPosition
            // 
            this.lblNameAddPosition.AutoSize = true;
            this.lblNameAddPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNameAddPosition.Location = new System.Drawing.Point(18, 275);
            this.lblNameAddPosition.Name = "lblNameAddPosition";
            this.lblNameAddPosition.Size = new System.Drawing.Size(101, 17);
            this.lblNameAddPosition.TabIndex = 6;
            this.lblNameAddPosition.Text = "Dział nadrzędny";
            // 
            // lblLocationAddDepartment
            // 
            this.lblLocationAddDepartment.AutoSize = true;
            this.lblLocationAddDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLocationAddDepartment.Location = new System.Drawing.Point(18, 177);
            this.lblLocationAddDepartment.Name = "lblLocationAddDepartment";
            this.lblLocationAddDepartment.Size = new System.Drawing.Size(70, 17);
            this.lblLocationAddDepartment.TabIndex = 7;
            this.lblLocationAddDepartment.Text = "Lokalizacja";
            // 
            // lblManagerAddDepartment
            // 
            this.lblManagerAddDepartment.AutoSize = true;
            this.lblManagerAddDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblManagerAddDepartment.Location = new System.Drawing.Point(18, 146);
            this.lblManagerAddDepartment.Name = "lblManagerAddDepartment";
            this.lblManagerAddDepartment.Size = new System.Drawing.Size(102, 17);
            this.lblManagerAddDepartment.TabIndex = 8;
            this.lblManagerAddDepartment.Text = "Kierownik działu";
            // 
            // lnlNameAddDepartemnt
            // 
            this.lnlNameAddDepartemnt.AutoSize = true;
            this.lnlNameAddDepartemnt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnlNameAddDepartemnt.Location = new System.Drawing.Point(18, 103);
            this.lnlNameAddDepartemnt.Name = "lnlNameAddDepartemnt";
            this.lnlNameAddDepartemnt.Size = new System.Drawing.Size(47, 17);
            this.lnlNameAddDepartemnt.TabIndex = 9;
            this.lnlNameAddDepartemnt.Text = "Nazwa";
            // 
            // tbAddNameDepartment
            // 
            this.tbAddNameDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAddNameDepartment.Location = new System.Drawing.Point(199, 100);
            this.tbAddNameDepartment.Name = "tbAddNameDepartment";
            this.tbAddNameDepartment.Size = new System.Drawing.Size(165, 25);
            this.tbAddNameDepartment.TabIndex = 10;
            this.tbAddNameDepartment.TextChanged += new System.EventHandler(this.tbAddNameDepartment_TextChanged);
            // 
            // tbManagerAddDepartment
            // 
            this.tbManagerAddDepartment.Enabled = false;
            this.tbManagerAddDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbManagerAddDepartment.Location = new System.Drawing.Point(199, 138);
            this.tbManagerAddDepartment.Name = "tbManagerAddDepartment";
            this.tbManagerAddDepartment.Size = new System.Drawing.Size(165, 25);
            this.tbManagerAddDepartment.TabIndex = 11;
            this.tbManagerAddDepartment.TextChanged += new System.EventHandler(this.tbManagerAddDepartment_TextChanged);
            // 
            // tbLocationAddDepartment
            // 
            this.tbLocationAddDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLocationAddDepartment.Location = new System.Drawing.Point(199, 174);
            this.tbLocationAddDepartment.Multiline = true;
            this.tbLocationAddDepartment.Name = "tbLocationAddDepartment";
            this.tbLocationAddDepartment.Size = new System.Drawing.Size(165, 79);
            this.tbLocationAddDepartment.TabIndex = 12;
            // 
            // tbDepartmentAdd
            // 
            this.tbDepartmentAdd.Enabled = false;
            this.tbDepartmentAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDepartmentAdd.Location = new System.Drawing.Point(199, 267);
            this.tbDepartmentAdd.Name = "tbDepartmentAdd";
            this.tbDepartmentAdd.Size = new System.Drawing.Size(165, 25);
            this.tbDepartmentAdd.TabIndex = 13;
            this.tbDepartmentAdd.TextChanged += new System.EventHandler(this.tbDepartmentAdd_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(352, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 15;
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
            this.btnSave.Location = new System.Drawing.Point(226, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epNameDepartment
            // 
            this.epNameDepartment.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNameDepartment.ContainerControl = this;
            // 
            // epManagerDepartment
            // 
            this.epManagerDepartment.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epManagerDepartment.ContainerControl = this;
            // 
            // epMainDepartment
            // 
            this.epMainDepartment.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epMainDepartment.ContainerControl = this;
            // 
            // btnAddEmployeeDepartment
            // 
            this.btnAddEmployeeDepartment.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddEmployeeDepartment.Location = new System.Drawing.Point(408, 138);
            this.btnAddEmployeeDepartment.Name = "btnAddEmployeeDepartment";
            this.btnAddEmployeeDepartment.Size = new System.Drawing.Size(51, 25);
            this.btnAddEmployeeDepartment.TabIndex = 16;
            this.btnAddEmployeeDepartment.Text = "dodaj";
            this.btnAddEmployeeDepartment.UseVisualStyleBackColor = false;
            this.btnAddEmployeeDepartment.Click += new System.EventHandler(this.btnAddEmployeeDepartment_Click);
            // 
            // btnAddMainDepartment
            // 
            this.btnAddMainDepartment.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddMainDepartment.Location = new System.Drawing.Point(408, 267);
            this.btnAddMainDepartment.Name = "btnAddMainDepartment";
            this.btnAddMainDepartment.Size = new System.Drawing.Size(51, 25);
            this.btnAddMainDepartment.TabIndex = 17;
            this.btnAddMainDepartment.Text = "dodaj";
            this.btnAddMainDepartment.UseVisualStyleBackColor = false;
            this.btnAddMainDepartment.Click += new System.EventHandler(this.btnAddMainDepartment_Click);
            // 
            // DepartmentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 371);
            this.Controls.Add(this.btnAddMainDepartment);
            this.Controls.Add(this.btnAddEmployeeDepartment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDepartmentAdd);
            this.Controls.Add(this.tbLocationAddDepartment);
            this.Controls.Add(this.tbManagerAddDepartment);
            this.Controls.Add(this.tbAddNameDepartment);
            this.Controls.Add(this.lnlNameAddDepartemnt);
            this.Controls.Add(this.lblManagerAddDepartment);
            this.Controls.Add(this.lblLocationAddDepartment);
            this.Controls.Add(this.lblNameAddPosition);
            this.Controls.Add(this.pbAddDepartment);
            this.Controls.Add(this.lblAddDepartment);
            this.Name = "DepartmentAddForm";
            this.Text = "Dodaj dział";
            ((System.ComponentModel.ISupportInitialize)(this.pbAddDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNameDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epManagerDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMainDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAddDepartment;
        private System.Windows.Forms.Label lblAddDepartment;
        private System.Windows.Forms.Label lblNameAddPosition;
        private System.Windows.Forms.Label lblLocationAddDepartment;
        private System.Windows.Forms.Label lblManagerAddDepartment;
        private System.Windows.Forms.Label lnlNameAddDepartemnt;
        private System.Windows.Forms.TextBox tbAddNameDepartment;
        private System.Windows.Forms.TextBox tbManagerAddDepartment;
        private System.Windows.Forms.TextBox tbLocationAddDepartment;
        private System.Windows.Forms.TextBox tbDepartmentAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epNameDepartment;
        private System.Windows.Forms.ErrorProvider epManagerDepartment;
        private System.Windows.Forms.ErrorProvider epMainDepartment;
        private System.Windows.Forms.Button btnAddMainDepartment;
        private System.Windows.Forms.Button btnAddEmployeeDepartment;
    }
}