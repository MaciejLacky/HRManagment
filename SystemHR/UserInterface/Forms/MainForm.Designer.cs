namespace SystemHR.UserInterface.Forms
{
    partial class MainForm
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
            this.tcName = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.btnPositions = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnOrganizationalStructure = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnContracts = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.pConfiguration = new System.Windows.Forms.Panel();
            this.btnEmailConfig = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.SSMain = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.tcTab = new System.Windows.Forms.TabControl();
            this.tcName.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpConfiguration.SuspendLayout();
            this.pConfiguration.SuspendLayout();
            this.SSMain.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcName
            // 
            this.tcName.Controls.Add(this.tpGeneral);
            this.tcName.Controls.Add(this.tpConfiguration);
            this.tcName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcName.Location = new System.Drawing.Point(0, 0);
            this.tcName.Name = "tcName";
            this.tcName.SelectedIndex = 0;
            this.tcName.Size = new System.Drawing.Size(1020, 78);
            this.tcName.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btnPositions);
            this.tpGeneral.Controls.Add(this.splitter5);
            this.tpGeneral.Controls.Add(this.btnDepartments);
            this.tpGeneral.Controls.Add(this.splitter4);
            this.tpGeneral.Controls.Add(this.btnSalaries);
            this.tpGeneral.Controls.Add(this.splitter3);
            this.tpGeneral.Controls.Add(this.btnOrganizationalStructure);
            this.tpGeneral.Controls.Add(this.splitter2);
            this.tpGeneral.Controls.Add(this.btnContracts);
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btnEmployees);
            this.tpGeneral.Location = new System.Drawing.Point(4, 26);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(1012, 48);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            this.tpGeneral.Click += new System.EventHandler(this.tpGeneral_Click);
            // 
            // btnPositions
            // 
            this.btnPositions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPositions.Image = global::SystemHR.UserInterface.Properties.Resources.Positions_32;
            this.btnPositions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPositions.Location = new System.Drawing.Point(689, 3);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(127, 42);
            this.btnPositions.TabIndex = 10;
            this.btnPositions.Text = "Stanowiska";
            this.btnPositions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPositions.UseVisualStyleBackColor = true;
            this.btnPositions.Click += new System.EventHandler(this.btnPositions_Click);
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(684, 3);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(5, 42);
            this.splitter5.TabIndex = 9;
            this.splitter5.TabStop = false;
            // 
            // btnDepartments
            // 
            this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartments.Image = global::SystemHR.UserInterface.Properties.Resources.Departments_32;
            this.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.Location = new System.Drawing.Point(581, 3);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(103, 42);
            this.btnDepartments.TabIndex = 8;
            this.btnDepartments.Text = "Działy";
            this.btnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartments.UseVisualStyleBackColor = true;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(576, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(5, 42);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // btnSalaries
            // 
            this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalaries.Image = global::SystemHR.UserInterface.Properties.Resources.Salary_32;
            this.btnSalaries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaries.Location = new System.Drawing.Point(431, 3);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(145, 42);
            this.btnSalaries.TabIndex = 6;
            this.btnSalaries.Text = "Wynagrodzenia";
            this.btnSalaries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalaries.UseVisualStyleBackColor = true;
            this.btnSalaries.Click += new System.EventHandler(this.btnSalaries_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(426, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 42);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // btnOrganizationalStructure
            // 
            this.btnOrganizationalStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrganizationalStructure.Image = global::SystemHR.UserInterface.Properties.Resources.OrganizationalUnits_32;
            this.btnOrganizationalStructure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganizationalStructure.Location = new System.Drawing.Point(236, 3);
            this.btnOrganizationalStructure.Name = "btnOrganizationalStructure";
            this.btnOrganizationalStructure.Size = new System.Drawing.Size(190, 42);
            this.btnOrganizationalStructure.TabIndex = 4;
            this.btnOrganizationalStructure.Text = "Struktura Organizacyjna";
            this.btnOrganizationalStructure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrganizationalStructure.UseVisualStyleBackColor = true;
            this.btnOrganizationalStructure.Click += new System.EventHandler(this.btnOrganizationalStructure_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(231, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 42);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // btnContracts
            // 
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContracts.Image = global::SystemHR.UserInterface.Properties.Resources.Contracts_32;
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(128, 3);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(103, 42);
            this.btnContracts.TabIndex = 2;
            this.btnContracts.Text = "Umowy";
            this.btnContracts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(123, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 42);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployees.Image = global::SystemHR.UserInterface.Properties.Resources.Emplyees_32;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(3, 3);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 42);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Pracownicy";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Controls.Add(this.pConfiguration);
            this.tpConfiguration.Location = new System.Drawing.Point(4, 26);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(1012, 48);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // pConfiguration
            // 
            this.pConfiguration.Controls.Add(this.btnEmailConfig);
            this.pConfiguration.Controls.Add(this.btnUsers);
            this.pConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pConfiguration.Location = new System.Drawing.Point(3, 3);
            this.pConfiguration.Name = "pConfiguration";
            this.pConfiguration.Size = new System.Drawing.Size(1006, 42);
            this.pConfiguration.TabIndex = 0;
            // 
            // btnEmailConfig
            // 
            this.btnEmailConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmailConfig.Image = global::SystemHR.UserInterface.Properties.Resources.email_24;
            this.btnEmailConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmailConfig.Location = new System.Drawing.Point(120, 0);
            this.btnEmailConfig.Name = "btnEmailConfig";
            this.btnEmailConfig.Size = new System.Drawing.Size(150, 42);
            this.btnEmailConfig.TabIndex = 2;
            this.btnEmailConfig.Text = "Konfiguracja Email";
            this.btnEmailConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmailConfig.UseVisualStyleBackColor = true;
            this.btnEmailConfig.Click += new System.EventHandler(this.btnEmailConfig_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUsers.Image = global::SystemHR.UserInterface.Properties.Resources.User_16;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(120, 42);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Użytkownicy";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // SSMain
            // 
            this.SSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDatabase,
            this.tsslUser});
            this.SSMain.Location = new System.Drawing.Point(0, 625);
            this.SSMain.Name = "SSMain";
            this.SSMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.SSMain.Size = new System.Drawing.Size(1020, 22);
            this.SSMain.TabIndex = 1;
            this.SSMain.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(81, 17);
            this.tsslVersion.Text = "Wersja: 1.0.0.0";
            // 
            // tsslDatabase
            // 
            this.tsslDatabase.Image = global::SystemHR.UserInterface.Properties.Resources.Database_16;
            this.tsslDatabase.Name = "tsslDatabase";
            this.tsslDatabase.Size = new System.Drawing.Size(144, 17);
            this.tsslDatabase.Text = "Baza: Human Resource";
            // 
            // tsslUser
            // 
            this.tsslUser.Image = global::SystemHR.UserInterface.Properties.Resources.Emplyees_32;
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(155, 17);
            this.tsslUser.Text = "Użytkownik: Maciej Łącki";
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.Window;
            this.pMain.Controls.Add(this.tcTab);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 78);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1020, 547);
            this.pMain.TabIndex = 2;
            // 
            // tcTab
            // 
            this.tcTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTab.ItemSize = new System.Drawing.Size(150, 20);
            this.tcTab.Location = new System.Drawing.Point(0, 0);
            this.tcTab.Name = "tcTab";
            this.tcTab.SelectedIndex = 0;
            this.tcTab.Size = new System.Drawing.Size(1020, 547);
            this.tcTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTab.TabIndex = 0;
            this.tcTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.tcTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 647);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.SSMain);
            this.Controls.Add(this.tcName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System HR";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcName.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpConfiguration.ResumeLayout(false);
            this.pConfiguration.ResumeLayout(false);
            this.SSMain.ResumeLayout(false);
            this.SSMain.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcName;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button btnSalaries;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnOrganizationalStructure;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.StatusStrip SSMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatabase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.TabControl tcTab;
        private System.Windows.Forms.Panel pConfiguration;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnEmailConfig;
    }
}