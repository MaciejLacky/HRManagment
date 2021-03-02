namespace SystemHR.UserInterface.Forms.OrganizationalStructure
{
    partial class OrganizationalStructureForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.organizationalStructureModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.działDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kierownikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokalizacjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationalStructureModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.działDataGridViewTextBoxColumn,
            this.kierownikDataGridViewTextBoxColumn,
            this.lokalizacjaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.organizationalStructureModelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // organizationalStructureModelBindingSource
            // 
            this.organizationalStructureModelBindingSource.DataSource = typeof(SystemHR.DataAccessLayer.ViewModels.OrganizationalStructureModel);
            // 
            // działDataGridViewTextBoxColumn
            // 
            this.działDataGridViewTextBoxColumn.DataPropertyName = "Dział";
            this.działDataGridViewTextBoxColumn.HeaderText = "Dział";
            this.działDataGridViewTextBoxColumn.Name = "działDataGridViewTextBoxColumn";
            this.działDataGridViewTextBoxColumn.Width = 200;
            // 
            // kierownikDataGridViewTextBoxColumn
            // 
            this.kierownikDataGridViewTextBoxColumn.DataPropertyName = "Kierownik";
            this.kierownikDataGridViewTextBoxColumn.HeaderText = "Kierownik";
            this.kierownikDataGridViewTextBoxColumn.Name = "kierownikDataGridViewTextBoxColumn";
            this.kierownikDataGridViewTextBoxColumn.Width = 200;
            // 
            // lokalizacjaDataGridViewTextBoxColumn
            // 
            this.lokalizacjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lokalizacjaDataGridViewTextBoxColumn.DataPropertyName = "Lokalizacja";
            this.lokalizacjaDataGridViewTextBoxColumn.HeaderText = "Lokalizacja";
            this.lokalizacjaDataGridViewTextBoxColumn.Name = "lokalizacjaDataGridViewTextBoxColumn";
            // 
            // OrganizationalStructureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrganizationalStructureForm";
            this.Text = "Struktura Organizacyjna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrganizationalStructureForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationalStructureModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn działDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kierownikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokalizacjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource organizationalStructureModelBindingSource;
    }
}