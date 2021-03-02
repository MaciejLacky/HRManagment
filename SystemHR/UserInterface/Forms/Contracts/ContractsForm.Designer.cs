namespace SystemHR.UserInterface.Forms.Contracts
{
    partial class ContractsForm
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
            this.tlpContracts = new System.Windows.Forms.TableLayoutPanel();
            this.pContracts = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConclusionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colterminationWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsContracts = new System.Windows.Forms.BindingSource(this.components);
            this.tlpContracts.SuspendLayout();
            this.pContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpContracts
            // 
            this.tlpContracts.ColumnCount = 1;
            this.tlpContracts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContracts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContracts.Controls.Add(this.pContracts, 0, 0);
            this.tlpContracts.Controls.Add(this.dgvContracts, 0, 1);
            this.tlpContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContracts.Location = new System.Drawing.Point(0, 0);
            this.tlpContracts.Name = "tlpContracts";
            this.tlpContracts.RowCount = 2;
            this.tlpContracts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpContracts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContracts.Size = new System.Drawing.Size(800, 450);
            this.tlpContracts.TabIndex = 0;
            // 
            // pContracts
            // 
            this.pContracts.Controls.Add(this.btnRefresh);
            this.pContracts.Controls.Add(this.btnDelete);
            this.pContracts.Controls.Add(this.btnView);
            this.pContracts.Controls.Add(this.btnCreate);
            this.pContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContracts.Location = new System.Drawing.Point(3, 3);
            this.pContracts.Name = "pContracts";
            this.pContracts.Size = new System.Drawing.Size(794, 34);
            this.pContracts.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Window;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::SystemHR.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(280, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Image = global::SystemHR.UserInterface.Properties.Resources.delete_24;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(190, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.Window;
            this.btnView.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnView.Image = global::SystemHR.UserInterface.Properties.Resources.edit_24;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(90, 0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 34);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "Podgląd";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            this.btnCreate.Size = new System.Drawing.Size(90, 34);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Dodaj";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvContracts
            // 
            this.dgvContracts.AutoGenerateColumns = false;
            this.dgvContracts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colLastName,
            this.colFirstName,
            this.colDateFrom,
            this.colDateTo,
            this.colConclusionDate,
            this.colterminationWay});
            this.dgvContracts.DataSource = this.bsContracts;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContracts.Location = new System.Drawing.Point(3, 43);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.RowHeadersVisible = false;
            this.dgvContracts.Size = new System.Drawing.Size(794, 404);
            this.dgvContracts.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Nazwisko";
            this.colLastName.Name = "colLastName";
            this.colLastName.ToolTipText = "Nazwisko Pracownika";
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "Imie";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ToolTipText = "Imie Pracownika";
            // 
            // colDateFrom
            // 
            this.colDateFrom.DataPropertyName = "DateFrom";
            this.colDateFrom.HeaderText = "Data od";
            this.colDateFrom.Name = "colDateFrom";
            this.colDateFrom.ToolTipText = "Data umowy od";
            // 
            // colDateTo
            // 
            this.colDateTo.DataPropertyName = "DateTo";
            this.colDateTo.HeaderText = "Data do";
            this.colDateTo.Name = "colDateTo";
            this.colDateTo.ToolTipText = "Data umowy do";
            // 
            // colConclusionDate
            // 
            this.colConclusionDate.DataPropertyName = "ConclusionDate";
            this.colConclusionDate.HeaderText = "Data zakończenia";
            this.colConclusionDate.Name = "colConclusionDate";
            this.colConclusionDate.ToolTipText = "Data zakończenia umowy";
            this.colConclusionDate.Width = 150;
            // 
            // colterminationWay
            // 
            this.colterminationWay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colterminationWay.DataPropertyName = "TerminationWay";
            this.colterminationWay.HeaderText = "Sposób wypowiedzenia";
            this.colterminationWay.Name = "colterminationWay";
            this.colterminationWay.ToolTipText = "Sposób wypowiedzenia umowy";
            // 
            // bsContracts
            // 
            this.bsContracts.DataSource = typeof(SystemHR.DataAccessLayer.ViewModels.ContractViewModel);
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpContracts);
            this.Name = "ContractsForm";
            this.Text = "Umowy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContractsForm_FormClosed);
            this.tlpContracts.ResumeLayout(false);
            this.pContracts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContracts;
        private System.Windows.Forms.Panel pContracts;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConclusionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colterminationWay;
        private System.Windows.Forms.BindingSource bsContracts;
    }
}