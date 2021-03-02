namespace SystemHR.UserInterface.Forms.Departments
{
    partial class DepartmentsForm
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
            this.tlpDepartments = new System.Windows.Forms.TableLayoutPanel();
            this.pDepartments = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.tlpDepartments.SuspendLayout();
            this.pDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpDepartments
            // 
            this.tlpDepartments.ColumnCount = 1;
            this.tlpDepartments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDepartments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDepartments.Controls.Add(this.pDepartments, 0, 0);
            this.tlpDepartments.Controls.Add(this.dgvDepartments, 0, 1);
            this.tlpDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDepartments.Location = new System.Drawing.Point(0, 0);
            this.tlpDepartments.Name = "tlpDepartments";
            this.tlpDepartments.RowCount = 2;
            this.tlpDepartments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpDepartments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDepartments.Size = new System.Drawing.Size(800, 450);
            this.tlpDepartments.TabIndex = 0;
            // 
            // pDepartments
            // 
            this.pDepartments.Controls.Add(this.btnRefresh);
            this.pDepartments.Controls.Add(this.btnRemove);
            this.pDepartments.Controls.Add(this.btnModify);
            this.pDepartments.Controls.Add(this.btnCreate);
            this.pDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDepartments.Location = new System.Drawing.Point(3, 3);
            this.pDepartments.Name = "pDepartments";
            this.pDepartments.Size = new System.Drawing.Size(794, 34);
            this.pDepartments.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Window;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::SystemHR.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(295, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Window;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Image = global::SystemHR.UserInterface.Properties.Resources.delete_24;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(205, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 34);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.Window;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Image = global::SystemHR.UserInterface.Properties.Resources.edit_24;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(100, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(105, 34);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.Window;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.Image = global::SystemHR.UserInterface.Properties.Resources.add_24;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 34);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Dodaj";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AutoGenerateColumns = false;
            this.dgvDepartments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colManager,
            this.colLocation,
            this.colParentDepartment});
            this.dgvDepartments.DataSource = this.bsDepartment;
            this.dgvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartments.Location = new System.Drawing.Point(3, 43);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.RowHeadersVisible = false;
            this.dgvDepartments.Size = new System.Drawing.Size(794, 404);
            this.dgvDepartments.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Nazwa";
            this.colName.Name = "colName";
            this.colName.ToolTipText = "Nazwa Działu";
            // 
            // colManager
            // 
            this.colManager.DataPropertyName = "Manager";
            this.colManager.HeaderText = "Kierownik Działu";
            this.colManager.Name = "colManager";
            this.colManager.ToolTipText = "Kierownik Działu";
            this.colManager.Width = 150;
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "Location";
            this.colLocation.HeaderText = "Lokalizacja";
            this.colLocation.Name = "colLocation";
            this.colLocation.ToolTipText = "Lokalizacja działu";
            this.colLocation.Width = 250;
            // 
            // colParentDepartment
            // 
            this.colParentDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colParentDepartment.DataPropertyName = "ParentDepartment";
            this.colParentDepartment.HeaderText = "Dział Nadrzędny";
            this.colParentDepartment.Name = "colParentDepartment";
            this.colParentDepartment.ToolTipText = "Dział nadrzędny";
            // 
            // bsDepartment
            // 
            this.bsDepartment.DataSource = typeof(SystemHR.DataAccessLayer.ViewModels.DepartmentViewModel);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpDepartments);
            this.Name = "DepartmentsForm";
            this.Text = "Działy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentsForm_FormClosed);
            this.tlpDepartments.ResumeLayout(false);
            this.pDepartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDepartments;
        private System.Windows.Forms.Panel pDepartments;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentDepartment;
        private System.Windows.Forms.BindingSource bsDepartment;
    }
}