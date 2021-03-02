namespace SystemHR.UserInterface.Forms.Salaries
{
    partial class SalariesForm
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
            this.tlpSalary = new System.Windows.Forms.TableLayoutPanel();
            this.pbtnSalary = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pdataSalary = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpSalary.SuspendLayout();
            this.pbtnSalary.SuspendLayout();
            this.pdataSalary.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpSalary
            // 
            this.tlpSalary.ColumnCount = 1;
            this.tlpSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSalary.Controls.Add(this.pbtnSalary, 0, 0);
            this.tlpSalary.Controls.Add(this.pdataSalary, 0, 1);
            this.tlpSalary.Controls.Add(this.dataGridView1, 0, 2);
            this.tlpSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSalary.Location = new System.Drawing.Point(0, 0);
            this.tlpSalary.Name = "tlpSalary";
            this.tlpSalary.RowCount = 3;
            this.tlpSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpSalary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSalary.Size = new System.Drawing.Size(800, 450);
            this.tlpSalary.TabIndex = 0;
            // 
            // pbtnSalary
            // 
            this.pbtnSalary.Controls.Add(this.btnNext);
            this.pbtnSalary.Controls.Add(this.btnPrevious);
            this.pbtnSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbtnSalary.Location = new System.Drawing.Point(3, 3);
            this.pbtnSalary.Name = "pbtnSalary";
            this.pbtnSalary.Size = new System.Drawing.Size(794, 34);
            this.pbtnSalary.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Window;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.Image = global::SystemHR.UserInterface.Properties.Resources.edit_24;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(120, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 34);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Następny";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Window;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrevious.Image = global::SystemHR.UserInterface.Properties.Resources.return1;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(120, 34);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Poprzedni";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // pdataSalary
            // 
            this.pdataSalary.Controls.Add(this.tableLayoutPanel1);
            this.pdataSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdataSalary.Location = new System.Drawing.Point(3, 43);
            this.pdataSalary.Name = "pdataSalary";
            this.pdataSalary.Size = new System.Drawing.Size(794, 74);
            this.pdataSalary.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Location = new System.Drawing.Point(561, 45);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(94, 20);
            this.textBox8.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(493, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 37);
            this.label8.TabIndex = 14;
            this.label8.Text = "Stanowisko";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(393, 45);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(94, 20);
            this.textBox7.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(346, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "PESEL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(246, 45);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(94, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(159, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data Urodzenia";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(53, 45);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Płeć";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(561, 8);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(493, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(246, 8);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(159, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwisko";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(53, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colAmount,
            this.colCurrency,
            this.colTypeRate,
            this.colDateFrom,
            this.colDateTo});
            this.dataGridView1.DataSource = this.salaryViewModelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(794, 324);
            this.dataGridView1.TabIndex = 2;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Kwota";
            this.colAmount.Name = "colAmount";
            this.colAmount.ToolTipText = "Kwota wynagrodzenia";
            // 
            // colCurrency
            // 
            this.colCurrency.DataPropertyName = "Currency";
            this.colCurrency.HeaderText = "Waluta";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ToolTipText = "Waluta wynagrodzenia";
            // 
            // colTypeRate
            // 
            this.colTypeRate.DataPropertyName = "TypeRate";
            this.colTypeRate.HeaderText = "Rodzaj Stawki";
            this.colTypeRate.Name = "colTypeRate";
            this.colTypeRate.ToolTipText = "Rodzaj stawki wynagrodzenia";
            this.colTypeRate.Width = 150;
            // 
            // colDateFrom
            // 
            this.colDateFrom.DataPropertyName = "DateFrom";
            this.colDateFrom.HeaderText = "Data Od";
            this.colDateFrom.Name = "colDateFrom";
            this.colDateFrom.ToolTipText = "data od";
            this.colDateFrom.Width = 150;
            // 
            // colDateTo
            // 
            this.colDateTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDateTo.DataPropertyName = "DateTo";
            this.colDateTo.HeaderText = "Data Do";
            this.colDateTo.Name = "colDateTo";
            this.colDateTo.ToolTipText = "Data do";
            // 
            // salaryViewModelBindingSource
            // 
            this.salaryViewModelBindingSource.DataSource = typeof(SystemHR.DataAccessLayer.ViewModels.SalaryViewModel);
            // 
            // SalariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpSalary);
            this.Name = "SalariesForm";
            this.Text = "Wynagrodzenia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalariesForm_FormClosed);
            this.tlpSalary.ResumeLayout(false);
            this.pbtnSalary.ResumeLayout(false);
            this.pdataSalary.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSalary;
        private System.Windows.Forms.Panel pbtnSalary;
        private System.Windows.Forms.Panel pdataSalary;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTo;
        private System.Windows.Forms.BindingSource salaryViewModelBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}