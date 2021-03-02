namespace SystemHR.UserInterface.Forms.Positions
{
    partial class PositionAddForm
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
            this.lblAddPosition = new System.Windows.Forms.Label();
            this.pbAddPosition = new System.Windows.Forms.PictureBox();
            this.lblNameAddPosition = new System.Windows.Forms.Label();
            this.lblMaxsalaryAddPosition = new System.Windows.Forms.Label();
            this.lblMinSalaryAddPosition = new System.Windows.Forms.Label();
            this.tbAddNamePosition = new System.Windows.Forms.TextBox();
            this.nudAddMaxSalaryPosition = new System.Windows.Forms.NumericUpDown();
            this.nudAddMinSalaryPosition = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.eppositionName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMaxSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMinSalary = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddMaxSalaryPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddMinSalaryPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eppositionName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaxSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMinSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddPosition
            // 
            this.lblAddPosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddPosition.AutoSize = true;
            this.lblAddPosition.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPosition.Location = new System.Drawing.Point(29, 30);
            this.lblAddPosition.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblAddPosition.Name = "lblAddPosition";
            this.lblAddPosition.Size = new System.Drawing.Size(116, 30);
            this.lblAddPosition.TabIndex = 2;
            this.lblAddPosition.Text = "Stanowisko";
            // 
            // pbAddPosition
            // 
            this.pbAddPosition.Image = global::SystemHR.UserInterface.Properties.Resources.Positions_32;
            this.pbAddPosition.Location = new System.Drawing.Point(409, 13);
            this.pbAddPosition.Name = "pbAddPosition";
            this.pbAddPosition.Size = new System.Drawing.Size(64, 64);
            this.pbAddPosition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddPosition.TabIndex = 3;
            this.pbAddPosition.TabStop = false;
            // 
            // lblNameAddPosition
            // 
            this.lblNameAddPosition.AutoSize = true;
            this.lblNameAddPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNameAddPosition.Location = new System.Drawing.Point(31, 108);
            this.lblNameAddPosition.Name = "lblNameAddPosition";
            this.lblNameAddPosition.Size = new System.Drawing.Size(47, 17);
            this.lblNameAddPosition.TabIndex = 4;
            this.lblNameAddPosition.Text = "Nazwa";
            // 
            // lblMaxsalaryAddPosition
            // 
            this.lblMaxsalaryAddPosition.AutoSize = true;
            this.lblMaxsalaryAddPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaxsalaryAddPosition.Location = new System.Drawing.Point(31, 155);
            this.lblMaxsalaryAddPosition.Name = "lblMaxsalaryAddPosition";
            this.lblMaxsalaryAddPosition.Size = new System.Drawing.Size(125, 17);
            this.lblMaxsalaryAddPosition.TabIndex = 5;
            this.lblMaxsalaryAddPosition.Text = "Max wynagrodzenie";
            // 
            // lblMinSalaryAddPosition
            // 
            this.lblMinSalaryAddPosition.AutoSize = true;
            this.lblMinSalaryAddPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinSalaryAddPosition.Location = new System.Drawing.Point(32, 201);
            this.lblMinSalaryAddPosition.Name = "lblMinSalaryAddPosition";
            this.lblMinSalaryAddPosition.Size = new System.Drawing.Size(122, 17);
            this.lblMinSalaryAddPosition.TabIndex = 6;
            this.lblMinSalaryAddPosition.Text = "Min wynagrodzenie";
            // 
            // tbAddNamePosition
            // 
            this.tbAddNamePosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAddNamePosition.Location = new System.Drawing.Point(230, 100);
            this.tbAddNamePosition.Name = "tbAddNamePosition";
            this.tbAddNamePosition.Size = new System.Drawing.Size(165, 25);
            this.tbAddNamePosition.TabIndex = 7;
            this.tbAddNamePosition.TextChanged += new System.EventHandler(this.tbAddNamePosition_TextChanged);
            // 
            // nudAddMaxSalaryPosition
            // 
            this.nudAddMaxSalaryPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudAddMaxSalaryPosition.Location = new System.Drawing.Point(230, 147);
            this.nudAddMaxSalaryPosition.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAddMaxSalaryPosition.Name = "nudAddMaxSalaryPosition";
            this.nudAddMaxSalaryPosition.Size = new System.Drawing.Size(165, 25);
            this.nudAddMaxSalaryPosition.TabIndex = 8;
            this.nudAddMaxSalaryPosition.ValueChanged += new System.EventHandler(this.nudAddMaxSalaryPosition_ValueChanged);
            // 
            // nudAddMinSalaryPosition
            // 
            this.nudAddMinSalaryPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudAddMinSalaryPosition.Location = new System.Drawing.Point(230, 193);
            this.nudAddMinSalaryPosition.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudAddMinSalaryPosition.Name = "nudAddMinSalaryPosition";
            this.nudAddMinSalaryPosition.Size = new System.Drawing.Size(165, 25);
            this.nudAddMinSalaryPosition.TabIndex = 9;
            this.nudAddMinSalaryPosition.ValueChanged += new System.EventHandler(this.nudAddMinSalaryPosition_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(356, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 11;
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
            this.btnSave.Location = new System.Drawing.Point(230, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // eppositionName
            // 
            this.eppositionName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.eppositionName.ContainerControl = this;
            // 
            // epMaxSalary
            // 
            this.epMaxSalary.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epMaxSalary.ContainerControl = this;
            // 
            // epMinSalary
            // 
            this.epMinSalary.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epMinSalary.ContainerControl = this;
            // 
            // PositionAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudAddMinSalaryPosition);
            this.Controls.Add(this.nudAddMaxSalaryPosition);
            this.Controls.Add(this.tbAddNamePosition);
            this.Controls.Add(this.lblMinSalaryAddPosition);
            this.Controls.Add(this.lblMaxsalaryAddPosition);
            this.Controls.Add(this.lblNameAddPosition);
            this.Controls.Add(this.pbAddPosition);
            this.Controls.Add(this.lblAddPosition);
            this.Name = "PositionAddForm";
            this.Text = "Dodaj stanowisko";
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddMaxSalaryPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddMinSalaryPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eppositionName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaxSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMinSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddPosition;
        private System.Windows.Forms.PictureBox pbAddPosition;
        private System.Windows.Forms.Label lblNameAddPosition;
        private System.Windows.Forms.Label lblMaxsalaryAddPosition;
        private System.Windows.Forms.Label lblMinSalaryAddPosition;
        private System.Windows.Forms.TextBox tbAddNamePosition;
        private System.Windows.Forms.NumericUpDown nudAddMaxSalaryPosition;
        private System.Windows.Forms.NumericUpDown nudAddMinSalaryPosition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider eppositionName;
        private System.Windows.Forms.ErrorProvider epMaxSalary;
        private System.Windows.Forms.ErrorProvider epMinSalary;
    }
}