namespace SystemHR.UserInterface.Forms.Employees
{
    partial class EmployeeAddForm
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
            this.lblEmployee = new System.Windows.Forms.Label();
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
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.txtEmailAdress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmailAdress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.gbIdentityCard = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDateIdentityCard = new System.Windows.Forms.DateTimePicker();
            this.lblExpiredDateCardIdentityNumber = new System.Windows.Forms.Label();
            this.dtpIssueDateIdentityCardNumber = new System.Windows.Forms.DateTimePicker();
            this.txtIdentityCardNumber = new System.Windows.Forms.TextBox();
            this.lblIssueDateIdentityCard = new System.Windows.Forms.Label();
            this.lblIdentityCardNumber = new System.Windows.Forms.Label();
            this.gbPassport = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDatePassport = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDatePassport = new System.Windows.Forms.Label();
            this.dtpIssueDatePassport = new System.Windows.Forms.DateTimePicker();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.lblIssueDatePassport = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPesel = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpExpiredIdentityCardNumber = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpIssueIdentityCardNumber = new System.Windows.Forms.DateTimePicker();
            this.txttIdentityCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).BeginInit();
            this.gbContact.SuspendLayout();
            this.gbIdentityCard.SuspendLayout();
            this.gbPassport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPesel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployee.Location = new System.Drawing.Point(22, 28);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(207, 30);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Dane Identyfikacyjne";
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
            this.gbGeneral.Location = new System.Drawing.Point(27, 89);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(361, 205);
            this.gbGeneral.TabIndex = 1;
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
            this.txtPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesel_KeyPress);
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
            // gbContact
            // 
            this.gbContact.Controls.Add(this.txtEmailAdress);
            this.gbContact.Controls.Add(this.txtPhoneNumber);
            this.gbContact.Controls.Add(this.lblEmailAdress);
            this.gbContact.Controls.Add(this.lblPhoneNumber);
            this.gbContact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbContact.Location = new System.Drawing.Point(27, 315);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(361, 113);
            this.gbContact.TabIndex = 3;
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
            // gbIdentityCard
            // 
            this.gbIdentityCard.Controls.Add(this.dtpExpirationDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.lblExpiredDateCardIdentityNumber);
            this.gbIdentityCard.Controls.Add(this.dtpIssueDateIdentityCardNumber);
            this.gbIdentityCard.Controls.Add(this.txtIdentityCardNumber);
            this.gbIdentityCard.Controls.Add(this.lblIssueDateIdentityCard);
            this.gbIdentityCard.Controls.Add(this.lblIdentityCardNumber);
            this.gbIdentityCard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbIdentityCard.Location = new System.Drawing.Point(452, 89);
            this.gbIdentityCard.Name = "gbIdentityCard";
            this.gbIdentityCard.Size = new System.Drawing.Size(361, 145);
            this.gbIdentityCard.TabIndex = 4;
            this.gbIdentityCard.TabStop = false;
            this.gbIdentityCard.Text = "Dowód osobisty";
            // 
            // dtpExpirationDateIdentityCard
            // 
            this.dtpExpirationDateIdentityCard.CustomFormat = " ";
            this.dtpExpirationDateIdentityCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpExpirationDateIdentityCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDateIdentityCard.Location = new System.Drawing.Point(166, 89);
            this.dtpExpirationDateIdentityCard.Name = "dtpExpirationDateIdentityCard";
            this.dtpExpirationDateIdentityCard.Size = new System.Drawing.Size(165, 25);
            this.dtpExpirationDateIdentityCard.TabIndex = 10;
            this.dtpExpirationDateIdentityCard.ValueChanged += new System.EventHandler(this.dtb_ValueChanged);
            // 
            // lblExpiredDateCardIdentityNumber
            // 
            this.lblExpiredDateCardIdentityNumber.AutoSize = true;
            this.lblExpiredDateCardIdentityNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExpiredDateCardIdentityNumber.Location = new System.Drawing.Point(6, 97);
            this.lblExpiredDateCardIdentityNumber.Name = "lblExpiredDateCardIdentityNumber";
            this.lblExpiredDateCardIdentityNumber.Size = new System.Drawing.Size(91, 17);
            this.lblExpiredDateCardIdentityNumber.TabIndex = 9;
            this.lblExpiredDateCardIdentityNumber.Text = "Data ważności";
            // 
            // dtpIssueDateIdentityCardNumber
            // 
            this.dtpIssueDateIdentityCardNumber.CustomFormat = " ";
            this.dtpIssueDateIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpIssueDateIdentityCardNumber.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDateIdentityCardNumber.Location = new System.Drawing.Point(166, 58);
            this.dtpIssueDateIdentityCardNumber.Name = "dtpIssueDateIdentityCardNumber";
            this.dtpIssueDateIdentityCardNumber.Size = new System.Drawing.Size(165, 25);
            this.dtpIssueDateIdentityCardNumber.TabIndex = 8;
            this.dtpIssueDateIdentityCardNumber.ValueChanged += new System.EventHandler(this.dtb_ValueChanged);
            // 
            // txtIdentityCardNumber
            // 
            this.txtIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIdentityCardNumber.Location = new System.Drawing.Point(166, 27);
            this.txtIdentityCardNumber.Name = "txtIdentityCardNumber";
            this.txtIdentityCardNumber.Size = new System.Drawing.Size(165, 25);
            this.txtIdentityCardNumber.TabIndex = 2;
            // 
            // lblIssueDateIdentityCard
            // 
            this.lblIssueDateIdentityCard.AutoSize = true;
            this.lblIssueDateIdentityCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIssueDateIdentityCard.Location = new System.Drawing.Point(6, 66);
            this.lblIssueDateIdentityCard.Name = "lblIssueDateIdentityCard";
            this.lblIssueDateIdentityCard.Size = new System.Drawing.Size(86, 17);
            this.lblIssueDateIdentityCard.TabIndex = 1;
            this.lblIssueDateIdentityCard.Text = "Data wydania";
            // 
            // lblIdentityCardNumber
            // 
            this.lblIdentityCardNumber.AutoSize = true;
            this.lblIdentityCardNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdentityCardNumber.Location = new System.Drawing.Point(6, 35);
            this.lblIdentityCardNumber.Name = "lblIdentityCardNumber";
            this.lblIdentityCardNumber.Size = new System.Drawing.Size(101, 17);
            this.lblIdentityCardNumber.TabIndex = 0;
            this.lblIdentityCardNumber.Text = "Numer Dowodu";
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
            this.gbPassport.Location = new System.Drawing.Point(452, 283);
            this.gbPassport.Name = "gbPassport";
            this.gbPassport.Size = new System.Drawing.Size(361, 145);
            this.gbPassport.TabIndex = 5;
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(693, 482);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 7;
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
            this.btnSave.Location = new System.Drawing.Point(567, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::SystemHR.UserInterface.Properties.Resources.employee_64;
            this.pbEmployee.Location = new System.Drawing.Point(768, 12);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(64, 64);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEmployee.TabIndex = 2;
            this.pbEmployee.TabStop = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpExpiredIdentityCardNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpIssueIdentityCardNumber);
            this.groupBox1.Controls.Add(this.txttIdentityCardNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(452, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 145);
            this.groupBox1.TabIndex = 4;
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
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPassport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbIdentityCard);
            this.Controls.Add(this.gbContact);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.lblEmployee);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(25, 39);
            this.Name = "EmployeeAddForm";
            this.Text = "Dodaj Pracownika";
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).EndInit();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbIdentityCard.ResumeLayout(false);
            this.gbIdentityCard.PerformLayout();
            this.gbPassport.ResumeLayout(false);
            this.gbPassport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPesel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
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
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.TextBox txtEmailAdress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmailAdress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox gbIdentityCard;
        private System.Windows.Forms.DateTimePicker dtpIssueDateIdentityCardNumber;
        private System.Windows.Forms.TextBox txtIdentityCardNumber;
        private System.Windows.Forms.Label lblIssueDateIdentityCard;
        private System.Windows.Forms.Label lblIdentityCardNumber;
        private System.Windows.Forms.DateTimePicker dtpExpirationDateIdentityCard;
        private System.Windows.Forms.Label lblExpiredDateCardIdentityNumber;
        private System.Windows.Forms.GroupBox gbPassport;
        private System.Windows.Forms.DateTimePicker dtpExpirationDatePassport;
        private System.Windows.Forms.Label lblExpirationDatePassport;
        private System.Windows.Forms.DateTimePicker dtpIssueDatePassport;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.Label lblIssueDatePassport;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsGender;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epPesel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpExpiredIdentityCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIssueIdentityCardNumber;
        private System.Windows.Forms.TextBox txttIdentityCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}