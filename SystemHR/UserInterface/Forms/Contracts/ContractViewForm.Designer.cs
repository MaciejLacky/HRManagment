namespace SystemHR.UserInterface.Forms.Contracts
{
    partial class ContractViewForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDepartmentViewContract = new System.Windows.Forms.Label();
            this.lblViewContract = new System.Windows.Forms.Label();
            this.lblPositionViewContract = new System.Windows.Forms.Label();
            this.lblDateToViewContract = new System.Windows.Forms.Label();
            this.lblDateFromViewContarct = new System.Windows.Forms.Label();
            this.pbViewContract = new System.Windows.Forms.PictureBox();
            this.tbDepartmentViewContract = new System.Windows.Forms.TextBox();
            this.tbPositionViewContract = new System.Windows.Forms.TextBox();
            this.gbGeneralAddContract = new System.Windows.Forms.GroupBox();
            this.txtLastNameViewContract = new System.Windows.Forms.TextBox();
            this.txtFirstNameViewContract = new System.Windows.Forms.TextBox();
            this.lblLastNameViewContract = new System.Windows.Forms.Label();
            this.lblFirstNameViewContract = new System.Windows.Forms.Label();
            this.lblGenreViewContract = new System.Windows.Forms.Label();
            this.gbViewContract = new System.Windows.Forms.GroupBox();
            this.lblIssueDateViewContract = new System.Windows.Forms.Label();
            this.gbSalaryViewContract = new System.Windows.Forms.GroupBox();
            this.lblRateOfSalaryViewContract = new System.Windows.Forms.Label();
            this.tvAmountViewContract = new System.Windows.Forms.TextBox();
            this.lblCurrencyViewForm = new System.Windows.Forms.Label();
            this.lblAmountViewContract = new System.Windows.Forms.Label();
            this.tbDateToViewContract = new System.Windows.Forms.TextBox();
            this.tbDateFromViewContract = new System.Windows.Forms.TextBox();
            this.tbDateIssueViewContract = new System.Windows.Forms.TextBox();
            this.tbViewGenreContract = new System.Windows.Forms.TextBox();
            this.tbCurrencyViewContract = new System.Windows.Forms.TextBox();
            this.tbRateOfSalaryViewContract = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewContract)).BeginInit();
            this.gbGeneralAddContract.SuspendLayout();
            this.gbViewContract.SuspendLayout();
            this.gbSalaryViewContract.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(256, 610);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 23;
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
            this.btnSave.Location = new System.Drawing.Point(130, 610);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDepartmentViewContract
            // 
            this.lblDepartmentViewContract.AutoSize = true;
            this.lblDepartmentViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDepartmentViewContract.Location = new System.Drawing.Point(6, 192);
            this.lblDepartmentViewContract.Name = "lblDepartmentViewContract";
            this.lblDepartmentViewContract.Size = new System.Drawing.Size(36, 17);
            this.lblDepartmentViewContract.TabIndex = 17;
            this.lblDepartmentViewContract.Text = "Dział";
            // 
            // lblViewContract
            // 
            this.lblViewContract.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblViewContract.AutoSize = true;
            this.lblViewContract.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewContract.Location = new System.Drawing.Point(19, 30);
            this.lblViewContract.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblViewContract.Name = "lblViewContract";
            this.lblViewContract.Size = new System.Drawing.Size(167, 30);
            this.lblViewContract.TabIndex = 16;
            this.lblViewContract.Text = "Umowa - Numer";
            // 
            // lblPositionViewContract
            // 
            this.lblPositionViewContract.AutoSize = true;
            this.lblPositionViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPositionViewContract.Location = new System.Drawing.Point(6, 161);
            this.lblPositionViewContract.Name = "lblPositionViewContract";
            this.lblPositionViewContract.Size = new System.Drawing.Size(73, 17);
            this.lblPositionViewContract.TabIndex = 16;
            this.lblPositionViewContract.Text = "Stanowisko";
            // 
            // lblDateToViewContract
            // 
            this.lblDateToViewContract.AutoSize = true;
            this.lblDateToViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateToViewContract.Location = new System.Drawing.Point(6, 128);
            this.lblDateToViewContract.Name = "lblDateToViewContract";
            this.lblDateToViewContract.Size = new System.Drawing.Size(55, 17);
            this.lblDateToViewContract.TabIndex = 12;
            this.lblDateToViewContract.Text = "Data do";
            // 
            // lblDateFromViewContarct
            // 
            this.lblDateFromViewContarct.AutoSize = true;
            this.lblDateFromViewContarct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateFromViewContarct.Location = new System.Drawing.Point(6, 97);
            this.lblDateFromViewContarct.Name = "lblDateFromViewContarct";
            this.lblDateFromViewContarct.Size = new System.Drawing.Size(55, 17);
            this.lblDateFromViewContarct.TabIndex = 9;
            this.lblDateFromViewContarct.Text = "Data od";
            // 
            // pbViewContract
            // 
            this.pbViewContract.Image = global::SystemHR.UserInterface.Properties.Resources.paper;
            this.pbViewContract.Location = new System.Drawing.Point(311, 10);
            this.pbViewContract.Name = "pbViewContract";
            this.pbViewContract.Size = new System.Drawing.Size(64, 64);
            this.pbViewContract.TabIndex = 18;
            this.pbViewContract.TabStop = false;
            // 
            // tbDepartmentViewContract
            // 
            this.tbDepartmentViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDepartmentViewContract.Location = new System.Drawing.Point(166, 184);
            this.tbDepartmentViewContract.Name = "tbDepartmentViewContract";
            this.tbDepartmentViewContract.Size = new System.Drawing.Size(165, 25);
            this.tbDepartmentViewContract.TabIndex = 15;
            // 
            // tbPositionViewContract
            // 
            this.tbPositionViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPositionViewContract.Location = new System.Drawing.Point(166, 153);
            this.tbPositionViewContract.Name = "tbPositionViewContract";
            this.tbPositionViewContract.Size = new System.Drawing.Size(165, 25);
            this.tbPositionViewContract.TabIndex = 14;
            // 
            // gbGeneralAddContract
            // 
            this.gbGeneralAddContract.Controls.Add(this.txtLastNameViewContract);
            this.gbGeneralAddContract.Controls.Add(this.txtFirstNameViewContract);
            this.gbGeneralAddContract.Controls.Add(this.lblLastNameViewContract);
            this.gbGeneralAddContract.Controls.Add(this.lblFirstNameViewContract);
            this.gbGeneralAddContract.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbGeneralAddContract.Location = new System.Drawing.Point(11, 98);
            this.gbGeneralAddContract.Name = "gbGeneralAddContract";
            this.gbGeneralAddContract.Size = new System.Drawing.Size(361, 104);
            this.gbGeneralAddContract.TabIndex = 19;
            this.gbGeneralAddContract.TabStop = false;
            this.gbGeneralAddContract.Text = "Pracownik";
            // 
            // txtLastNameViewContract
            // 
            this.txtLastNameViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLastNameViewContract.Location = new System.Drawing.Point(166, 58);
            this.txtLastNameViewContract.Name = "txtLastNameViewContract";
            this.txtLastNameViewContract.Size = new System.Drawing.Size(165, 25);
            this.txtLastNameViewContract.TabIndex = 3;
            // 
            // txtFirstNameViewContract
            // 
            this.txtFirstNameViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFirstNameViewContract.Location = new System.Drawing.Point(166, 27);
            this.txtFirstNameViewContract.Name = "txtFirstNameViewContract";
            this.txtFirstNameViewContract.Size = new System.Drawing.Size(165, 25);
            this.txtFirstNameViewContract.TabIndex = 2;
            // 
            // lblLastNameViewContract
            // 
            this.lblLastNameViewContract.AutoSize = true;
            this.lblLastNameViewContract.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastNameViewContract.Location = new System.Drawing.Point(6, 66);
            this.lblLastNameViewContract.Name = "lblLastNameViewContract";
            this.lblLastNameViewContract.Size = new System.Drawing.Size(65, 17);
            this.lblLastNameViewContract.TabIndex = 1;
            this.lblLastNameViewContract.Text = "Nazwisko";
            // 
            // lblFirstNameViewContract
            // 
            this.lblFirstNameViewContract.AutoSize = true;
            this.lblFirstNameViewContract.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstNameViewContract.Location = new System.Drawing.Point(6, 35);
            this.lblFirstNameViewContract.Name = "lblFirstNameViewContract";
            this.lblFirstNameViewContract.Size = new System.Drawing.Size(34, 17);
            this.lblFirstNameViewContract.TabIndex = 0;
            this.lblFirstNameViewContract.Text = "Imię";
            // 
            // lblGenreViewContract
            // 
            this.lblGenreViewContract.AutoSize = true;
            this.lblGenreViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGenreViewContract.Location = new System.Drawing.Point(6, 35);
            this.lblGenreViewContract.Name = "lblGenreViewContract";
            this.lblGenreViewContract.Size = new System.Drawing.Size(48, 17);
            this.lblGenreViewContract.TabIndex = 0;
            this.lblGenreViewContract.Text = "Rodzaj";
            // 
            // gbViewContract
            // 
            this.gbViewContract.Controls.Add(this.tbViewGenreContract);
            this.gbViewContract.Controls.Add(this.tbDateIssueViewContract);
            this.gbViewContract.Controls.Add(this.tbDateFromViewContract);
            this.gbViewContract.Controls.Add(this.tbDateToViewContract);
            this.gbViewContract.Controls.Add(this.lblDepartmentViewContract);
            this.gbViewContract.Controls.Add(this.lblPositionViewContract);
            this.gbViewContract.Controls.Add(this.tbDepartmentViewContract);
            this.gbViewContract.Controls.Add(this.tbPositionViewContract);
            this.gbViewContract.Controls.Add(this.lblDateToViewContract);
            this.gbViewContract.Controls.Add(this.lblDateFromViewContarct);
            this.gbViewContract.Controls.Add(this.lblIssueDateViewContract);
            this.gbViewContract.Controls.Add(this.lblGenreViewContract);
            this.gbViewContract.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbViewContract.Location = new System.Drawing.Point(11, 208);
            this.gbViewContract.Name = "gbViewContract";
            this.gbViewContract.Size = new System.Drawing.Size(361, 245);
            this.gbViewContract.TabIndex = 21;
            this.gbViewContract.TabStop = false;
            this.gbViewContract.Text = "Umowa";
            // 
            // lblIssueDateViewContract
            // 
            this.lblIssueDateViewContract.AutoSize = true;
            this.lblIssueDateViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIssueDateViewContract.Location = new System.Drawing.Point(6, 66);
            this.lblIssueDateViewContract.Name = "lblIssueDateViewContract";
            this.lblIssueDateViewContract.Size = new System.Drawing.Size(89, 17);
            this.lblIssueDateViewContract.TabIndex = 1;
            this.lblIssueDateViewContract.Text = "Data zawarcia";
            // 
            // gbSalaryViewContract
            // 
            this.gbSalaryViewContract.Controls.Add(this.tbRateOfSalaryViewContract);
            this.gbSalaryViewContract.Controls.Add(this.tbCurrencyViewContract);
            this.gbSalaryViewContract.Controls.Add(this.lblRateOfSalaryViewContract);
            this.gbSalaryViewContract.Controls.Add(this.tvAmountViewContract);
            this.gbSalaryViewContract.Controls.Add(this.lblCurrencyViewForm);
            this.gbSalaryViewContract.Controls.Add(this.lblAmountViewContract);
            this.gbSalaryViewContract.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbSalaryViewContract.Location = new System.Drawing.Point(11, 459);
            this.gbSalaryViewContract.Name = "gbSalaryViewContract";
            this.gbSalaryViewContract.Size = new System.Drawing.Size(361, 147);
            this.gbSalaryViewContract.TabIndex = 24;
            this.gbSalaryViewContract.TabStop = false;
            this.gbSalaryViewContract.Text = "Wynagrodzenie";
            // 
            // lblRateOfSalaryViewContract
            // 
            this.lblRateOfSalaryViewContract.AutoSize = true;
            this.lblRateOfSalaryViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRateOfSalaryViewContract.Location = new System.Drawing.Point(6, 99);
            this.lblRateOfSalaryViewContract.Name = "lblRateOfSalaryViewContract";
            this.lblRateOfSalaryViewContract.Size = new System.Drawing.Size(87, 17);
            this.lblRateOfSalaryViewContract.TabIndex = 4;
            this.lblRateOfSalaryViewContract.Text = "Rodzaj stawki";
            // 
            // tvAmountViewContract
            // 
            this.tvAmountViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tvAmountViewContract.Location = new System.Drawing.Point(166, 27);
            this.tvAmountViewContract.Name = "tvAmountViewContract";
            this.tvAmountViewContract.Size = new System.Drawing.Size(165, 25);
            this.tvAmountViewContract.TabIndex = 2;
            // 
            // lblCurrencyViewForm
            // 
            this.lblCurrencyViewForm.AutoSize = true;
            this.lblCurrencyViewForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCurrencyViewForm.Location = new System.Drawing.Point(6, 66);
            this.lblCurrencyViewForm.Name = "lblCurrencyViewForm";
            this.lblCurrencyViewForm.Size = new System.Drawing.Size(47, 17);
            this.lblCurrencyViewForm.TabIndex = 1;
            this.lblCurrencyViewForm.Text = "Waluta";
            // 
            // lblAmountViewContract
            // 
            this.lblAmountViewContract.AutoSize = true;
            this.lblAmountViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAmountViewContract.Location = new System.Drawing.Point(6, 35);
            this.lblAmountViewContract.Name = "lblAmountViewContract";
            this.lblAmountViewContract.Size = new System.Drawing.Size(44, 17);
            this.lblAmountViewContract.TabIndex = 0;
            this.lblAmountViewContract.Text = "Kwota";
            // 
            // tbDateToViewContract
            // 
            this.tbDateToViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDateToViewContract.Location = new System.Drawing.Point(166, 120);
            this.tbDateToViewContract.Name = "tbDateToViewContract";
            this.tbDateToViewContract.Size = new System.Drawing.Size(165, 25);
            this.tbDateToViewContract.TabIndex = 18;
            // 
            // tbDateFromViewContract
            // 
            this.tbDateFromViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDateFromViewContract.Location = new System.Drawing.Point(166, 89);
            this.tbDateFromViewContract.Name = "tbDateFromViewContract";
            this.tbDateFromViewContract.Size = new System.Drawing.Size(165, 25);
            this.tbDateFromViewContract.TabIndex = 19;
            // 
            // tbDateIssueViewContract
            // 
            this.tbDateIssueViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDateIssueViewContract.Location = new System.Drawing.Point(166, 58);
            this.tbDateIssueViewContract.Name = "tbDateIssueViewContract";
            this.tbDateIssueViewContract.Size = new System.Drawing.Size(165, 25);
            this.tbDateIssueViewContract.TabIndex = 20;
            // 
            // tbViewGenreContract
            // 
            this.tbViewGenreContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbViewGenreContract.Location = new System.Drawing.Point(166, 27);
            this.tbViewGenreContract.Name = "tbViewGenreContract";
            this.tbViewGenreContract.Size = new System.Drawing.Size(165, 25);
            this.tbViewGenreContract.TabIndex = 21;
            // 
            // tbCurrencyViewContract
            // 
            this.tbCurrencyViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCurrencyViewContract.Location = new System.Drawing.Point(166, 58);
            this.tbCurrencyViewContract.Name = "tbCurrencyViewContract";
            this.tbCurrencyViewContract.Size = new System.Drawing.Size(165, 25);
            this.tbCurrencyViewContract.TabIndex = 5;
            // 
            // tbRateOfSalaryViewContract
            // 
            this.tbRateOfSalaryViewContract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRateOfSalaryViewContract.Location = new System.Drawing.Point(166, 89);
            this.tbRateOfSalaryViewContract.Name = "tbRateOfSalaryViewContract";
            this.tbRateOfSalaryViewContract.Size = new System.Drawing.Size(165, 25);
            this.tbRateOfSalaryViewContract.TabIndex = 6;
            // 
            // ContractViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 671);
            this.Controls.Add(this.gbSalaryViewContract);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblViewContract);
            this.Controls.Add(this.pbViewContract);
            this.Controls.Add(this.gbGeneralAddContract);
            this.Controls.Add(this.gbViewContract);
            this.Name = "ContractViewForm";
            this.Text = "Podgląd umowy o prace";
            ((System.ComponentModel.ISupportInitialize)(this.pbViewContract)).EndInit();
            this.gbGeneralAddContract.ResumeLayout(false);
            this.gbGeneralAddContract.PerformLayout();
            this.gbViewContract.ResumeLayout(false);
            this.gbViewContract.PerformLayout();
            this.gbSalaryViewContract.ResumeLayout(false);
            this.gbSalaryViewContract.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDepartmentViewContract;
        private System.Windows.Forms.Label lblViewContract;
        private System.Windows.Forms.Label lblPositionViewContract;
        private System.Windows.Forms.Label lblDateToViewContract;
        private System.Windows.Forms.Label lblDateFromViewContarct;
        private System.Windows.Forms.PictureBox pbViewContract;
        private System.Windows.Forms.TextBox tbDepartmentViewContract;
        private System.Windows.Forms.TextBox tbPositionViewContract;
        private System.Windows.Forms.GroupBox gbGeneralAddContract;
        private System.Windows.Forms.TextBox txtLastNameViewContract;
        private System.Windows.Forms.TextBox txtFirstNameViewContract;
        private System.Windows.Forms.Label lblLastNameViewContract;
        private System.Windows.Forms.Label lblFirstNameViewContract;
        private System.Windows.Forms.Label lblGenreViewContract;
        private System.Windows.Forms.GroupBox gbViewContract;
        private System.Windows.Forms.Label lblIssueDateViewContract;
        private System.Windows.Forms.TextBox tbViewGenreContract;
        private System.Windows.Forms.TextBox tbDateIssueViewContract;
        private System.Windows.Forms.TextBox tbDateFromViewContract;
        private System.Windows.Forms.TextBox tbDateToViewContract;
        private System.Windows.Forms.GroupBox gbSalaryViewContract;
        private System.Windows.Forms.TextBox tbRateOfSalaryViewContract;
        private System.Windows.Forms.TextBox tbCurrencyViewContract;
        private System.Windows.Forms.Label lblRateOfSalaryViewContract;
        private System.Windows.Forms.TextBox tvAmountViewContract;
        private System.Windows.Forms.Label lblCurrencyViewForm;
        private System.Windows.Forms.Label lblAmountViewContract;
    }
}