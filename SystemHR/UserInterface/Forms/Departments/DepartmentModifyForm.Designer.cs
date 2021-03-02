namespace SystemHR.UserInterface.Forms.Departments
{
    partial class DepartmentModifyForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbDepartmentAdd = new System.Windows.Forms.TextBox();
            this.tbLocationModifyDepartment = new System.Windows.Forms.TextBox();
            this.tbManagerModifyDepartment = new System.Windows.Forms.TextBox();
            this.tbModifyNameDepartment = new System.Windows.Forms.TextBox();
            this.lnlNameModifyDepartemnt = new System.Windows.Forms.Label();
            this.lblManagerModifyDepartment = new System.Windows.Forms.Label();
            this.lblLocationModifyDepartment = new System.Windows.Forms.Label();
            this.lblNameModifyPosition = new System.Windows.Forms.Label();
            this.pbModifyDepartment = new System.Windows.Forms.PictureBox();
            this.lblModifyDepartment = new System.Windows.Forms.Label();
            this.epNameDepartment = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbModifyDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNameDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(350, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 27;
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
            this.btnSave.Location = new System.Drawing.Point(224, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbDepartmentAdd
            // 
            this.tbDepartmentAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDepartmentAdd.Location = new System.Drawing.Point(197, 267);
            this.tbDepartmentAdd.Name = "tbDepartmentAdd";
            this.tbDepartmentAdd.Size = new System.Drawing.Size(165, 25);
            this.tbDepartmentAdd.TabIndex = 25;
            // 
            // tbLocationModifyDepartment
            // 
            this.tbLocationModifyDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLocationModifyDepartment.Location = new System.Drawing.Point(197, 174);
            this.tbLocationModifyDepartment.Multiline = true;
            this.tbLocationModifyDepartment.Name = "tbLocationModifyDepartment";
            this.tbLocationModifyDepartment.Size = new System.Drawing.Size(165, 79);
            this.tbLocationModifyDepartment.TabIndex = 24;
            // 
            // tbManagerModifyDepartment
            // 
            this.tbManagerModifyDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbManagerModifyDepartment.Location = new System.Drawing.Point(197, 138);
            this.tbManagerModifyDepartment.Name = "tbManagerModifyDepartment";
            this.tbManagerModifyDepartment.Size = new System.Drawing.Size(165, 25);
            this.tbManagerModifyDepartment.TabIndex = 23;
            // 
            // tbModifyNameDepartment
            // 
            this.tbModifyNameDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbModifyNameDepartment.Location = new System.Drawing.Point(197, 100);
            this.tbModifyNameDepartment.Name = "tbModifyNameDepartment";
            this.tbModifyNameDepartment.Size = new System.Drawing.Size(165, 25);
            this.tbModifyNameDepartment.TabIndex = 22;
            this.tbModifyNameDepartment.TextChanged += new System.EventHandler(this.tbAddNameDepartment_TextChanged);
            // 
            // lnlNameModifyDepartemnt
            // 
            this.lnlNameModifyDepartemnt.AutoSize = true;
            this.lnlNameModifyDepartemnt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnlNameModifyDepartemnt.Location = new System.Drawing.Point(16, 103);
            this.lnlNameModifyDepartemnt.Name = "lnlNameModifyDepartemnt";
            this.lnlNameModifyDepartemnt.Size = new System.Drawing.Size(47, 17);
            this.lnlNameModifyDepartemnt.TabIndex = 21;
            this.lnlNameModifyDepartemnt.Text = "Nazwa";
            // 
            // lblManagerModifyDepartment
            // 
            this.lblManagerModifyDepartment.AutoSize = true;
            this.lblManagerModifyDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblManagerModifyDepartment.Location = new System.Drawing.Point(16, 146);
            this.lblManagerModifyDepartment.Name = "lblManagerModifyDepartment";
            this.lblManagerModifyDepartment.Size = new System.Drawing.Size(102, 17);
            this.lblManagerModifyDepartment.TabIndex = 20;
            this.lblManagerModifyDepartment.Text = "Kierownik działu";
            // 
            // lblLocationModifyDepartment
            // 
            this.lblLocationModifyDepartment.AutoSize = true;
            this.lblLocationModifyDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLocationModifyDepartment.Location = new System.Drawing.Point(16, 177);
            this.lblLocationModifyDepartment.Name = "lblLocationModifyDepartment";
            this.lblLocationModifyDepartment.Size = new System.Drawing.Size(70, 17);
            this.lblLocationModifyDepartment.TabIndex = 19;
            this.lblLocationModifyDepartment.Text = "Lokalizacja";
            // 
            // lblNameModifyPosition
            // 
            this.lblNameModifyPosition.AutoSize = true;
            this.lblNameModifyPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNameModifyPosition.Location = new System.Drawing.Point(16, 275);
            this.lblNameModifyPosition.Name = "lblNameModifyPosition";
            this.lblNameModifyPosition.Size = new System.Drawing.Size(101, 17);
            this.lblNameModifyPosition.TabIndex = 18;
            this.lblNameModifyPosition.Text = "Dział nadrzędny";
            // 
            // pbModifyDepartment
            // 
            this.pbModifyDepartment.Image = global::SystemHR.UserInterface.Properties.Resources.Departments_32;
            this.pbModifyDepartment.Location = new System.Drawing.Point(406, 12);
            this.pbModifyDepartment.Name = "pbModifyDepartment";
            this.pbModifyDepartment.Size = new System.Drawing.Size(64, 64);
            this.pbModifyDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbModifyDepartment.TabIndex = 17;
            this.pbModifyDepartment.TabStop = false;
            // 
            // lblModifyDepartment
            // 
            this.lblModifyDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblModifyDepartment.AutoSize = true;
            this.lblModifyDepartment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyDepartment.Location = new System.Drawing.Point(14, 34);
            this.lblModifyDepartment.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblModifyDepartment.Name = "lblModifyDepartment";
            this.lblModifyDepartment.Size = new System.Drawing.Size(269, 30);
            this.lblModifyDepartment.TabIndex = 16;
            this.lblModifyDepartment.Text = "Modyfikacja działu: (nazwa)";
            // 
            // epNameDepartment
            // 
            this.epNameDepartment.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNameDepartment.ContainerControl = this;
            // 
            // DepartmentModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 371);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDepartmentAdd);
            this.Controls.Add(this.tbLocationModifyDepartment);
            this.Controls.Add(this.tbManagerModifyDepartment);
            this.Controls.Add(this.tbModifyNameDepartment);
            this.Controls.Add(this.lnlNameModifyDepartemnt);
            this.Controls.Add(this.lblManagerModifyDepartment);
            this.Controls.Add(this.lblLocationModifyDepartment);
            this.Controls.Add(this.lblNameModifyPosition);
            this.Controls.Add(this.pbModifyDepartment);
            this.Controls.Add(this.lblModifyDepartment);
            this.Name = "DepartmentModifyForm";
            this.Text = "Modyfikacja działu";
            ((System.ComponentModel.ISupportInitialize)(this.pbModifyDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNameDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbDepartmentAdd;
        private System.Windows.Forms.TextBox tbLocationModifyDepartment;
        private System.Windows.Forms.TextBox tbManagerModifyDepartment;
        private System.Windows.Forms.TextBox tbModifyNameDepartment;
        private System.Windows.Forms.Label lnlNameModifyDepartemnt;
        private System.Windows.Forms.Label lblManagerModifyDepartment;
        private System.Windows.Forms.Label lblLocationModifyDepartment;
        private System.Windows.Forms.Label lblNameModifyPosition;
        private System.Windows.Forms.PictureBox pbModifyDepartment;
        private System.Windows.Forms.Label lblModifyDepartment;
        private System.Windows.Forms.ErrorProvider epNameDepartment;
    }
}