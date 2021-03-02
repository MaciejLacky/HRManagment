namespace SystemHR.UserInterface.Forms.Positions
{
    partial class PositionForm
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
            this.tlpPosition = new System.Windows.Forms.TableLayoutPanel();
            this.pPosition = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPositions = new System.Windows.Forms.BindingSource(this.components);
            this.tlpPosition.SuspendLayout();
            this.pPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPosition
            // 
            this.tlpPosition.ColumnCount = 1;
            this.tlpPosition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPosition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPosition.Controls.Add(this.pPosition, 0, 0);
            this.tlpPosition.Controls.Add(this.dgvPositions, 0, 1);
            this.tlpPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPosition.Location = new System.Drawing.Point(0, 0);
            this.tlpPosition.Name = "tlpPosition";
            this.tlpPosition.RowCount = 2;
            this.tlpPosition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPosition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPosition.Size = new System.Drawing.Size(800, 450);
            this.tlpPosition.TabIndex = 0;
            // 
            // pPosition
            // 
            this.pPosition.Controls.Add(this.btnRefresh);
            this.pPosition.Controls.Add(this.btnRemove);
            this.pPosition.Controls.Add(this.btnModify);
            this.pPosition.Controls.Add(this.btnCreate);
            this.pPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPosition.Location = new System.Drawing.Point(3, 3);
            this.pPosition.Name = "pPosition";
            this.pPosition.Size = new System.Drawing.Size(794, 34);
            this.pPosition.TabIndex = 0;
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
            this.btnRefresh.TabIndex = 5;
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
            this.btnRemove.TabIndex = 4;
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
            this.btnModify.TabIndex = 2;
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
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Dodaj";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvPositions
            // 
            this.dgvPositions.AutoGenerateColumns = false;
            this.dgvPositions.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colMaxSalary,
            this.colMinSalary});
            this.dgvPositions.DataSource = this.bsPositions;
            this.dgvPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPositions.Location = new System.Drawing.Point(3, 43);
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.RowHeadersVisible = false;
            this.dgvPositions.Size = new System.Drawing.Size(794, 404);
            this.dgvPositions.TabIndex = 1;
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
            this.colName.ToolTipText = "Nazwa stanowiska";
            this.colName.Width = 150;
            // 
            // colMaxSalary
            // 
            this.colMaxSalary.DataPropertyName = "MaxSalary";
            this.colMaxSalary.HeaderText = "Maksymalne Wynagrodzenie";
            this.colMaxSalary.Name = "colMaxSalary";
            this.colMaxSalary.ToolTipText = "Maksymalne wynagrodzenie na stanowisku";
            this.colMaxSalary.Width = 200;
            // 
            // colMinSalary
            // 
            this.colMinSalary.DataPropertyName = "MinSalary";
            this.colMinSalary.HeaderText = "Minimalne Wynagrodzenie";
            this.colMinSalary.Name = "colMinSalary";
            this.colMinSalary.ToolTipText = "Minimalne wynagrodzenie pracownika";
            this.colMinSalary.Width = 200;
            // 
            // bsPositions
            // 
            this.bsPositions.DataSource = typeof(SystemHR.DataAccessLayer.ViewModels.PositionViewModel);
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPosition);
            this.Name = "PositionForm";
            this.Text = "Stanowiska";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PositionForm_FormClosed);
            this.tlpPosition.ResumeLayout(false);
            this.pPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPositions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPosition;
        private System.Windows.Forms.Panel pPosition;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.BindingSource bsPositions;
        private System.Windows.Forms.DataGridView dgvPositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinSalary;
    }
}