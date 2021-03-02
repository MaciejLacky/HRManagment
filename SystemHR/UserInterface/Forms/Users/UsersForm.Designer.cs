namespace SystemHR.UserInterface.Forms.Users
{
    partial class UsersForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pUsers = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.tlpUsers = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.pUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            this.tlpUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pUsers
            // 
            this.pUsers.Controls.Add(this.btnRefreshUsers);
            this.pUsers.Controls.Add(this.btnDeleteUser);
            this.pUsers.Controls.Add(this.btnModifyUser);
            this.pUsers.Controls.Add(this.btnCreateUser);
            this.pUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUsers.Location = new System.Drawing.Point(3, 3);
            this.pUsers.Name = "pUsers";
            this.pUsers.Size = new System.Drawing.Size(794, 34);
            this.pUsers.TabIndex = 0;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteUser.Image = global::SystemHR.UserInterface.Properties.Resources.dismiss_24;
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(195, 0);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(90, 34);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Usuń";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.BackColor = System.Drawing.SystemColors.Window;
            this.btnModifyUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModifyUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModifyUser.Image = global::SystemHR.UserInterface.Properties.Resources.edit_24;
            this.btnModifyUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyUser.Location = new System.Drawing.Point(90, 0);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(105, 34);
            this.btnModifyUser.TabIndex = 1;
            this.btnModifyUser.Text = "Modyfikuj";
            this.btnModifyUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyUser.UseVisualStyleBackColor = false;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.SystemColors.Window;
            this.btnCreateUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateUser.Image = global::SystemHR.UserInterface.Properties.Resources.add_24;
            this.btnCreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateUser.Location = new System.Drawing.Point(0, 0);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(90, 34);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Dodaj";
            this.btnCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colLastName,
            this.colFirstName,
            this.colCode,
            this.colPosition,
            this.colStatus});
            this.dgvEmployees.DataSource = this.bsEmployees;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 43);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(794, 404);
            this.dgvEmployees.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Nazwisko";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.ToolTipText = "Nazwisko Pracownika";
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "Imie";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.ToolTipText = "Imie Pracownika";
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Kod";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.ToolTipText = "Kod Pracownika";
            // 
            // colPosition
            // 
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.HeaderText = "Stanowisko";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            this.colPosition.ToolTipText = "Stanowisko Pracownika";
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.ToolTipText = "Status Pracownika";
            // 
            // bsEmployees
            // 
            this.bsEmployees.DataSource = typeof(SystemHR.DataAccessLayer.ViewModels.EmployeeViewModel);
            // 
            // tlpUsers
            // 
            this.tlpUsers.ColumnCount = 1;
            this.tlpUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUsers.Controls.Add(this.pUsers, 0, 0);
            this.tlpUsers.Controls.Add(this.dgvEmployees, 0, 1);
            this.tlpUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsers.Location = new System.Drawing.Point(0, 0);
            this.tlpUsers.Name = "tlpUsers";
            this.tlpUsers.RowCount = 2;
            this.tlpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsers.Size = new System.Drawing.Size(800, 450);
            this.tlpUsers.TabIndex = 1;
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.BackColor = System.Drawing.SystemColors.Window;
            this.btnRefreshUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefreshUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefreshUsers.Image = global::SystemHR.UserInterface.Properties.Resources.refresh_24;
            this.btnRefreshUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshUsers.Location = new System.Drawing.Point(285, 0);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(90, 34);
            this.btnRefreshUsers.TabIndex = 5;
            this.btnRefreshUsers.Text = "Odśwież";
            this.btnRefreshUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshUsers.UseVisualStyleBackColor = false;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpUsers);
            this.Name = "UsersForm";
            this.Text = "Użytkownicy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.pUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            this.tlpUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.BindingSource bsEmployees;
        private System.Windows.Forms.TableLayoutPanel tlpUsers;
        private System.Windows.Forms.Button btnRefreshUsers;
    }
}