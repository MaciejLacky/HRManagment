namespace SystemHR.UserInterface.Forms.Employees
{
    partial class EmployeeEditForm
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
            this.tlpEditEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.pEditEmployee = new System.Windows.Forms.Panel();
            this.pbEditEmployee = new System.Windows.Forms.PictureBox();
            this.lblEditEmployee = new System.Windows.Forms.Label();
            this.tabEditEmployee = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbPassport = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDatePassport = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDatePassport = new System.Windows.Forms.Label();
            this.dtpIssueDatePassport = new System.Windows.Forms.DateTimePicker();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.lblIssueDatePassport = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpExpiredIdentityCardNumber = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpIssueIdentityCardNumber = new System.Windows.Forms.DateTimePicker();
            this.txttIdentityCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.txtEmailAdress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmailAdress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.dtbDateBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.bsGender = new System.Windows.Forms.BindingSource(this.components);
            this.lblGender = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tpanelEditbtnEmployee = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPesel = new System.Windows.Forms.ErrorProvider(this.components);
            this.employeeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvModifyHistoryEmployee = new System.Windows.Forms.DataGridView();
            this.contractsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpEditEmployee.SuspendLayout();
            this.pEditEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditEmployee)).BeginInit();
            this.tabEditEmployee.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbPassport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbContact.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tpanelEditbtnEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPesel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyHistoryEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpEditEmployee
            // 
            this.tlpEditEmployee.ColumnCount = 1;
            this.tlpEditEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEditEmployee.Controls.Add(this.pEditEmployee, 0, 0);
            this.tlpEditEmployee.Controls.Add(this.tabEditEmployee, 0, 1);
            this.tlpEditEmployee.Controls.Add(this.tpanelEditbtnEmployee, 0, 2);
            this.tlpEditEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEditEmployee.Location = new System.Drawing.Point(0, 0);
            this.tlpEditEmployee.Name = "tlpEditEmployee";
            this.tlpEditEmployee.RowCount = 3;
            this.tlpEditEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpEditEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEditEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpEditEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEditEmployee.Size = new System.Drawing.Size(844, 561);
            this.tlpEditEmployee.TabIndex = 1;
            // 
            // pEditEmployee
            // 
            this.pEditEmployee.Controls.Add(this.pbEditEmployee);
            this.pEditEmployee.Controls.Add(this.lblEditEmployee);
            this.pEditEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEditEmployee.Location = new System.Drawing.Point(3, 3);
            this.pEditEmployee.Name = "pEditEmployee";
            this.pEditEmployee.Size = new System.Drawing.Size(838, 94);
            this.pEditEmployee.TabIndex = 1;
            // 
            // pbEditEmployee
            // 
            this.pbEditEmployee.Image = global::SystemHR.UserInterface.Properties.Resources.employee_64;
            this.pbEditEmployee.Location = new System.Drawing.Point(710, 16);
            this.pbEditEmployee.Name = "pbEditEmployee";
            this.pbEditEmployee.Size = new System.Drawing.Size(64, 64);
            this.pbEditEmployee.TabIndex = 1;
            this.pbEditEmployee.TabStop = false;
            // 
            // lblEditEmployee
            // 
            this.lblEditEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEditEmployee.AutoSize = true;
            this.lblEditEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmployee.Location = new System.Drawing.Point(20, 33);
            this.lblEditEmployee.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblEditEmployee.Name = "lblEditEmployee";
            this.lblEditEmployee.Size = new System.Drawing.Size(234, 30);
            this.lblEditEmployee.TabIndex = 0;
            this.lblEditEmployee.Text = "Imię i Nazwisko - Status";
            // 
            // tabEditEmployee
            // 
            this.tabEditEmployee.Controls.Add(this.tabPage1);
            this.tabEditEmployee.Controls.Add(this.tabPage2);
            this.tabEditEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEditEmployee.Location = new System.Drawing.Point(3, 103);
            this.tabEditEmployee.Name = "tabEditEmployee";
            this.tabEditEmployee.SelectedIndex = 0;
            this.tabEditEmployee.Size = new System.Drawing.Size(838, 395);
            this.tabEditEmployee.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbPassport);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gbContact);
            this.tabPage1.Controls.Add(this.gbGeneral);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(830, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dane identyfikacyjne";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbPassport
            // 
            this.gbPassport.Controls.Add(this.dtpExpirationDatePassport);
            this.gbPassport.Controls.Add(this.lblExpirationDatePassport);
            this.gbPassport.Controls.Add(this.dtpIssueDatePassport);
            this.gbPassport.Controls.Add(this.txtPassportNumber);
            this.gbPassport.Controls.Add(this.lblIssueDatePassport);
            this.gbPassport.Controls.Add(this.lblPassportNumber);
            this.gbPassport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPassport.Location = new System.Drawing.Point(447, 209);
            this.gbPassport.Name = "gbPassport";
            this.gbPassport.Size = new System.Drawing.Size(361, 145);
            this.gbPassport.TabIndex = 9;
            this.gbPassport.TabStop = false;
            this.gbPassport.Text = "Paszport";
            // 
            // dtpExpirationDatePassport
            // 
            this.dtpExpirationDatePassport.CustomFormat = " ";
            this.dtpExpirationDatePassport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpExpirationDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDatePassport.Location = new System.Drawing.Point(166, 89);
            this.dtpExpirationDatePassport.Name = "dtpExpirationDatePassport";
            this.dtpExpirationDatePassport.Size = new System.Drawing.Size(165, 25);
            this.dtpExpirationDatePassport.TabIndex = 10;
            this.dtpExpirationDatePassport.ValueChanged += new System.EventHandler(this.dtb_ValueChanged);
            // 
            // lblExpirationDatePassport
            // 
            this.lblExpirationDatePassport.AutoSize = true;
            this.lblExpirationDatePassport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExpirationDatePassport.Location = new System.Drawing.Point(6, 97);
            this.lblExpirationDatePassport.Name = "lblExpirationDatePassport";
            this.lblExpirationDatePassport.Size = new System.Drawing.Size(91, 17);
            this.lblExpirationDatePassport.TabIndex = 9;
            this.lblExpirationDatePassport.Text = "Data ważności";
            // 
            // dtpIssueDatePassport
            // 
            this.dtpIssueDatePassport.CustomFormat = " ";
            this.dtpIssueDatePassport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpIssueDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDatePassport.Location = new System.Drawing.Point(166, 58);
            this.dtpIssueDatePassport.Name = "dtpIssueDatePassport";
            this.dtpIssueDatePassport.Size = new System.Drawing.Size(165, 25);
            this.dtpIssueDatePassport.TabIndex = 8;
            this.dtpIssueDatePassport.ValueChanged += new System.EventHandler(this.dtb_ValueChanged);
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPassportNumber.Location = new System.Drawing.Point(166, 27);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(165, 25);
            this.txtPassportNumber.TabIndex = 2;
            // 
            // lblIssueDatePassport
            // 
            this.lblIssueDatePassport.AutoSize = true;
            this.lblIssueDatePassport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIssueDatePassport.Location = new System.Drawing.Point(6, 66);
            this.lblIssueDatePassport.Name = "lblIssueDatePassport";
            this.lblIssueDatePassport.Size = new System.Drawing.Size(86, 17);
            this.lblIssueDatePassport.TabIndex = 1;
            this.lblIssueDatePassport.Text = "Data wydania";
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassportNumber.Location = new System.Drawing.Point(6, 35);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(110, 17);
            this.lblPassportNumber.TabIndex = 0;
            this.lblPassportNumber.Text = "Numer Paszportu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpExpiredIdentityCardNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpIssueIdentityCardNumber);
            this.groupBox1.Controls.Add(this.txttIdentityCardNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(447, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 145);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dowód osobisty";
            // 
            // dtpExpiredIdentityCardNumber
            // 
            this.dtpExpiredIdentityCardNumber.CustomFormat = " ";
            this.dtpExpiredIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpExpiredIdentityCardNumber.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiredIdentityCardNumber.Location = new System.Drawing.Point(166, 89);
            this.dtpExpiredIdentityCardNumber.Name = "dtpExpiredIdentityCardNumber";
            this.dtpExpiredIdentityCardNumber.Size = new System.Drawing.Size(165, 25);
            this.dtpExpiredIdentityCardNumber.TabIndex = 10;
            this.dtpExpiredIdentityCardNumber.ValueChanged += new System.EventHandler(this.dtb_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data ważności";
            // 
            // dtpIssueIdentityCardNumber
            // 
            this.dtpIssueIdentityCardNumber.CustomFormat = " ";
            this.dtpIssueIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpIssueIdentityCardNumber.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueIdentityCardNumber.Location = new System.Drawing.Point(166, 58);
            this.dtpIssueIdentityCardNumber.Name = "dtpIssueIdentityCardNumber";
            this.dtpIssueIdentityCardNumber.Size = new System.Drawing.Size(165, 25);
            this.dtpIssueIdentityCardNumber.TabIndex = 8;
            this.dtpIssueIdentityCardNumber.ValueChanged += new System.EventHandler(this.dtb_ValueChanged);
            // 
            // txttIdentityCardNumber
            // 
            this.txttIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txttIdentityCardNumber.Location = new System.Drawing.Point(166, 27);
            this.txttIdentityCardNumber.Name = "txttIdentityCardNumber";
            this.txttIdentityCardNumber.Size = new System.Drawing.Size(165, 25);
            this.txttIdentityCardNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data wydania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numer Dowodu";
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.txtEmailAdress);
            this.gbContact.Controls.Add(this.txtPhoneNumber);
            this.gbContact.Controls.Add(this.lblEmailAdress);
            this.gbContact.Controls.Add(this.lblPhoneNumber);
            this.gbContact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbContact.Location = new System.Drawing.Point(22, 241);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(361, 113);
            this.gbContact.TabIndex = 7;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Kontakt";
            // 
            // txtEmailAdress
            // 
            this.txtEmailAdress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmailAdress.Location = new System.Drawing.Point(166, 58);
            this.txtEmailAdress.Name = "txtEmailAdress";
            this.txtEmailAdress.Size = new System.Drawing.Size(165, 25);
            this.txtEmailAdress.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(166, 27);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(165, 25);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // lblEmailAdress
            // 
            this.lblEmailAdress.AutoSize = true;
            this.lblEmailAdress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmailAdress.Location = new System.Drawing.Point(6, 66);
            this.lblEmailAdress.Name = "lblEmailAdress";
            this.lblEmailAdress.Size = new System.Drawing.Size(77, 17);
            this.lblEmailAdress.TabIndex = 1;
            this.lblEmailAdress.Text = "Adres email";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 35);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(101, 17);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Numer Telefonu";
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.txtPesel);
            this.gbGeneral.Controls.Add(this.lblPesel);
            this.gbGeneral.Controls.Add(this.dtbDateBirth);
            this.gbGeneral.Controls.Add(this.lblDateBirth);
            this.gbGeneral.Controls.Add(this.cmbGender);
            this.gbGeneral.Controls.Add(this.lblGender);
            this.gbGeneral.Controls.Add(this.txtFirstName);
            this.gbGeneral.Controls.Add(this.txtLastName);
            this.gbGeneral.Controls.Add(this.lblFirstName);
            this.gbGeneral.Controls.Add(this.lblLastName);
            this.gbGeneral.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbGeneral.Location = new System.Drawing.Point(22, 15);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(361, 205);
            this.gbGeneral.TabIndex = 6;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "Ogólne";
            // 
            // txtPesel
            // 
            this.txtPesel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPesel.Location = new System.Drawing.Point(166, 151);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(165, 25);
            this.txtPesel.TabIndex = 9;
            this.txtPesel.Validated += new System.EventHandler(this.txtPesel_Validated);
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesel.Location = new System.Drawing.Point(6, 159);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(42, 17);
            this.lblPesel.TabIndex = 8;
            this.lblPesel.Text = "PESEL";
            // 
            // dtbDateBirth
            // 
            this.dtbDateBirth.CustomFormat = " ";
            this.dtbDateBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtbDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbDateBirth.Location = new System.Drawing.Point(166, 120);
            this.dtbDateBirth.Name = "dtbDateBirth";
            this.dtbDateBirth.Size = new System.Drawing.Size(165, 25);
            this.dtbDateBirth.TabIndex = 7;
            this.dtbDateBirth.ValueChanged += new System.EventHandler(this.dtb_ValueChanged);
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.Location = new System.Drawing.Point(6, 128);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(97, 17);
            this.lblDateBirth.TabIndex = 6;
            this.lblDateBirth.Text = "Data urodzenia";
            // 
            // cmbGender
            // 
            this.cmbGender.DataSource = this.bsGender;
            this.cmbGender.DisplayMember = "Value";
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(166, 89);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(165, 25);
            this.cmbGender.TabIndex = 5;
            this.cmbGender.ValueMember = "Id";
            // 
            // bsGender
            // 
            this.bsGender.DataSource = typeof(SystemHR.DataAccessLayer.Models.Dictionaries.GenderModel);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(6, 97);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(31, 17);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Płeć";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFirstName.Location = new System.Drawing.Point(166, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 25);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLastName.Location = new System.Drawing.Point(166, 27);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 25);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(34, 17);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.Location = new System.Drawing.Point(6, 35);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(65, 17);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Nazwisko";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvModifyHistoryEmployee);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historia zatrudnienia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tpanelEditbtnEmployee
            // 
            this.tpanelEditbtnEmployee.Controls.Add(this.btnCancel);
            this.tpanelEditbtnEmployee.Controls.Add(this.btnSave);
            this.tpanelEditbtnEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpanelEditbtnEmployee.Location = new System.Drawing.Point(3, 504);
            this.tpanelEditbtnEmployee.Name = "tpanelEditbtnEmployee";
            this.tpanelEditbtnEmployee.Size = new System.Drawing.Size(838, 54);
            this.tpanelEditbtnEmployee.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(709, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 9;
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
            this.btnSave.Location = new System.Drawing.Point(583, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epLastName
            // 
            this.epLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLastName.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epFirstName.ContainerControl = this;
            // 
            // epPesel
            // 
            this.epPesel.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPesel.ContainerControl = this;
            // 
            // employeeModelBindingSource
            // 
            this.employeeModelBindingSource.DataSource = typeof(SystemHR.DataAccessLayer.Models.EmployeeModel);
            // 
            // dgvModifyHistoryEmployee
            // 
            this.dgvModifyHistoryEmployee.AutoGenerateColumns = false;
            this.dgvModifyHistoryEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifyHistoryEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateFromDataGridViewTextBoxColumn,
            this.dateToDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.typeContractDataGridViewTextBoxColumn});
            this.dgvModifyHistoryEmployee.DataSource = this.contractsModelBindingSource;
            this.dgvModifyHistoryEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModifyHistoryEmployee.Location = new System.Drawing.Point(3, 3);
            this.dgvModifyHistoryEmployee.Name = "dgvModifyHistoryEmployee";
            this.dgvModifyHistoryEmployee.RowHeadersVisible = false;
            this.dgvModifyHistoryEmployee.Size = new System.Drawing.Size(824, 363);
            this.dgvModifyHistoryEmployee.TabIndex = 0;
            // 
            // contractsModelBindingSource
            // 
            this.contractsModelBindingSource.DataSource = typeof(SystemHR.DataAccessLayer.Models.ContractsModel);
            // 
            // dateFromDataGridViewTextBoxColumn
            // 
            this.dateFromDataGridViewTextBoxColumn.DataPropertyName = "DateFrom";
            this.dateFromDataGridViewTextBoxColumn.HeaderText = "Data od";
            this.dateFromDataGridViewTextBoxColumn.Name = "dateFromDataGridViewTextBoxColumn";
            this.dateFromDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateToDataGridViewTextBoxColumn
            // 
            this.dateToDataGridViewTextBoxColumn.DataPropertyName = "DateTo";
            this.dateToDataGridViewTextBoxColumn.HeaderText = "Data do";
            this.dateToDataGridViewTextBoxColumn.Name = "dateToDataGridViewTextBoxColumn";
            this.dateToDataGridViewTextBoxColumn.Width = 150;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Stanowisko";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Dział";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // typeContractDataGridViewTextBoxColumn
            // 
            this.typeContractDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeContractDataGridViewTextBoxColumn.DataPropertyName = "TypeContract";
            this.typeContractDataGridViewTextBoxColumn.HeaderText = "Rodzaj umowy";
            this.typeContractDataGridViewTextBoxColumn.Name = "typeContractDataGridViewTextBoxColumn";
            // 
            // EmployeeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.tlpEditEmployee);
            this.Name = "EmployeeEditForm";
            this.Text = "Modyfikuj pracownika";
            this.tlpEditEmployee.ResumeLayout(false);
            this.pEditEmployee.ResumeLayout(false);
            this.pEditEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditEmployee)).EndInit();
            this.tabEditEmployee.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbPassport.ResumeLayout(false);
            this.gbPassport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tpanelEditbtnEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPesel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyHistoryEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEditEmployee;
        private System.Windows.Forms.Panel pEditEmployee;
        private System.Windows.Forms.PictureBox pbEditEmployee;
        private System.Windows.Forms.Label lblEditEmployee;
        private System.Windows.Forms.TabControl tabEditEmployee;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel tpanelEditbtnEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbPassport;
        private System.Windows.Forms.DateTimePicker dtpExpirationDatePassport;
        private System.Windows.Forms.Label lblExpirationDatePassport;
        private System.Windows.Forms.DateTimePicker dtpIssueDatePassport;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.Label lblIssueDatePassport;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpExpiredIdentityCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIssueIdentityCardNumber;
        private System.Windows.Forms.TextBox txttIdentityCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.TextBox txtEmailAdress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmailAdress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.DateTimePicker dtbDateBirth;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.BindingSource bsGender;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epPesel;
        private System.Windows.Forms.DataGridView dgvModifyHistoryEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contractsModelBindingSource;
        private System.Windows.Forms.BindingSource employeeModelBindingSource;
    }
}