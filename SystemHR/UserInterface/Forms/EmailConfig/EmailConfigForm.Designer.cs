namespace SystemHR.UserInterface.Forms.EmailConfig
{
    partial class EmailConfigForm
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.lblServerNameEmail = new System.Windows.Forms.Label();
            this.txbServerNameEmail = new System.Windows.Forms.TextBox();
            this.lblPortEmail = new System.Windows.Forms.Label();
            this.txbPortEmail = new System.Windows.Forms.TextBox();
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.txbPasswordEmail = new System.Windows.Forms.TextBox();
            this.lblPasswordEmail = new System.Windows.Forms.Label();
            this.txbUserEmail = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            this.gbEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(12, 19);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 30);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Poczta";
            // 
            // pbEmail
            // 
            this.pbEmail.Image = global::SystemHR.UserInterface.Properties.Resources.email__1_;
            this.pbEmail.Location = new System.Drawing.Point(318, 19);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(64, 64);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmail.TabIndex = 1;
            this.pbEmail.TabStop = false;
            // 
            // lblServerNameEmail
            // 
            this.lblServerNameEmail.AutoSize = true;
            this.lblServerNameEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblServerNameEmail.Location = new System.Drawing.Point(24, 114);
            this.lblServerNameEmail.Name = "lblServerNameEmail";
            this.lblServerNameEmail.Size = new System.Drawing.Size(92, 17);
            this.lblServerNameEmail.TabIndex = 2;
            this.lblServerNameEmail.Text = "Adres serwera";
            // 
            // txbServerNameEmail
            // 
            this.txbServerNameEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbServerNameEmail.Location = new System.Drawing.Point(217, 111);
            this.txbServerNameEmail.Name = "txbServerNameEmail";
            this.txbServerNameEmail.Size = new System.Drawing.Size(165, 25);
            this.txbServerNameEmail.TabIndex = 3;
            // 
            // lblPortEmail
            // 
            this.lblPortEmail.AutoSize = true;
            this.lblPortEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPortEmail.Location = new System.Drawing.Point(24, 145);
            this.lblPortEmail.Name = "lblPortEmail";
            this.lblPortEmail.Size = new System.Drawing.Size(32, 17);
            this.lblPortEmail.TabIndex = 4;
            this.lblPortEmail.Text = "Port";
            // 
            // txbPortEmail
            // 
            this.txbPortEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPortEmail.Location = new System.Drawing.Point(217, 142);
            this.txbPortEmail.Name = "txbPortEmail";
            this.txbPortEmail.Size = new System.Drawing.Size(165, 25);
            this.txbPortEmail.TabIndex = 5;
            // 
            // gbEmail
            // 
            this.gbEmail.Controls.Add(this.txbPasswordEmail);
            this.gbEmail.Controls.Add(this.lblPasswordEmail);
            this.gbEmail.Controls.Add(this.txbUserEmail);
            this.gbEmail.Controls.Add(this.lblUserEmail);
            this.gbEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbEmail.Location = new System.Drawing.Point(27, 205);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(365, 125);
            this.gbEmail.TabIndex = 6;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "Poświadczenia";
            // 
            // txbPasswordEmail
            // 
            this.txbPasswordEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPasswordEmail.Location = new System.Drawing.Point(190, 63);
            this.txbPasswordEmail.Name = "txbPasswordEmail";
            this.txbPasswordEmail.Size = new System.Drawing.Size(165, 25);
            this.txbPasswordEmail.TabIndex = 6;
            // 
            // lblPasswordEmail
            // 
            this.lblPasswordEmail.AutoSize = true;
            this.lblPasswordEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPasswordEmail.Location = new System.Drawing.Point(6, 66);
            this.lblPasswordEmail.Name = "lblPasswordEmail";
            this.lblPasswordEmail.Size = new System.Drawing.Size(41, 17);
            this.lblPasswordEmail.TabIndex = 5;
            this.lblPasswordEmail.Text = "Hasło";
            // 
            // txbUserEmail
            // 
            this.txbUserEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserEmail.Location = new System.Drawing.Point(190, 32);
            this.txbUserEmail.Name = "txbUserEmail";
            this.txbUserEmail.Size = new System.Drawing.Size(165, 25);
            this.txbUserEmail.TabIndex = 4;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUserEmail.Location = new System.Drawing.Point(6, 35);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(72, 17);
            this.lblUserEmail.TabIndex = 3;
            this.lblUserEmail.Text = "Użytkownik";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Image = global::SystemHR.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(146, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(272, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EmailConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 433);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbEmail);
            this.Controls.Add(this.txbPortEmail);
            this.Controls.Add(this.lblPortEmail);
            this.Controls.Add(this.txbServerNameEmail);
            this.Controls.Add(this.lblServerNameEmail);
            this.Controls.Add(this.pbEmail);
            this.Controls.Add(this.lblEmail);
            this.KeyPreview = true;
            this.Name = "EmailConfigForm";
            this.Text = "Konfiguracja Email";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmailConfigForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.Label lblServerNameEmail;
        private System.Windows.Forms.TextBox txbServerNameEmail;
        private System.Windows.Forms.Label lblPortEmail;
        private System.Windows.Forms.TextBox txbPortEmail;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.TextBox txbPasswordEmail;
        private System.Windows.Forms.Label lblPasswordEmail;
        private System.Windows.Forms.TextBox txbUserEmail;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}