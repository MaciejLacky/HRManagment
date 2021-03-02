namespace SystemHR.UserInterface.Forms.Positions
{
    partial class PositionModifyForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudModifyMinSalaryPosition = new System.Windows.Forms.NumericUpDown();
            this.nudModifyMaxSalaryPosition = new System.Windows.Forms.NumericUpDown();
            this.lblMinSalaryModifyPosition = new System.Windows.Forms.Label();
            this.lblMaxsalaryModifyPosition = new System.Windows.Forms.Label();
            this.lblNameAddPosition = new System.Windows.Forms.Label();
            this.pbModifyPosition = new System.Windows.Forms.PictureBox();
            this.lblModifyPosition = new System.Windows.Forms.Label();
            this.cmbNameModifyPosition = new System.Windows.Forms.ComboBox();
            this.eppositionName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudModifyMinSalaryPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModifyMaxSalaryPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModifyPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eppositionName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(346, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 21;
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
            this.btnSave.Location = new System.Drawing.Point(220, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudModifyMinSalaryPosition
            // 
            this.nudModifyMinSalaryPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudModifyMinSalaryPosition.Location = new System.Drawing.Point(220, 192);
            this.nudModifyMinSalaryPosition.Name = "nudModifyMinSalaryPosition";
            this.nudModifyMinSalaryPosition.Size = new System.Drawing.Size(165, 25);
            this.nudModifyMinSalaryPosition.TabIndex = 19;
            // 
            // nudModifyMaxSalaryPosition
            // 
            this.nudModifyMaxSalaryPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudModifyMaxSalaryPosition.Location = new System.Drawing.Point(220, 146);
            this.nudModifyMaxSalaryPosition.Name = "nudModifyMaxSalaryPosition";
            this.nudModifyMaxSalaryPosition.Size = new System.Drawing.Size(165, 25);
            this.nudModifyMaxSalaryPosition.TabIndex = 18;
            // 
            // lblMinSalaryModifyPosition
            // 
            this.lblMinSalaryModifyPosition.AutoSize = true;
            this.lblMinSalaryModifyPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinSalaryModifyPosition.Location = new System.Drawing.Point(22, 200);
            this.lblMinSalaryModifyPosition.Name = "lblMinSalaryModifyPosition";
            this.lblMinSalaryModifyPosition.Size = new System.Drawing.Size(122, 17);
            this.lblMinSalaryModifyPosition.TabIndex = 16;
            this.lblMinSalaryModifyPosition.Text = "Min wynagrodzenie";
            // 
            // lblMaxsalaryModifyPosition
            // 
            this.lblMaxsalaryModifyPosition.AutoSize = true;
            this.lblMaxsalaryModifyPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaxsalaryModifyPosition.Location = new System.Drawing.Point(21, 154);
            this.lblMaxsalaryModifyPosition.Name = "lblMaxsalaryModifyPosition";
            this.lblMaxsalaryModifyPosition.Size = new System.Drawing.Size(125, 17);
            this.lblMaxsalaryModifyPosition.TabIndex = 15;
            this.lblMaxsalaryModifyPosition.Text = "Max wynagrodzenie";
            // 
            // lblNameAddPosition
            // 
            this.lblNameAddPosition.AutoSize = true;
            this.lblNameAddPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNameAddPosition.Location = new System.Drawing.Point(21, 107);
            this.lblNameAddPosition.Name = "lblNameAddPosition";
            this.lblNameAddPosition.Size = new System.Drawing.Size(47, 17);
            this.lblNameAddPosition.TabIndex = 14;
            this.lblNameAddPosition.Text = "Nazwa";
            // 
            // pbModifyPosition
            // 
            this.pbModifyPosition.Image = global::SystemHR.UserInterface.Properties.Resources.Positions_32;
            this.pbModifyPosition.Location = new System.Drawing.Point(399, 12);
            this.pbModifyPosition.Name = "pbModifyPosition";
            this.pbModifyPosition.Size = new System.Drawing.Size(64, 64);
            this.pbModifyPosition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbModifyPosition.TabIndex = 13;
            this.pbModifyPosition.TabStop = false;
            // 
            // lblModifyPosition
            // 
            this.lblModifyPosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblModifyPosition.AutoSize = true;
            this.lblModifyPosition.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyPosition.Location = new System.Drawing.Point(19, 29);
            this.lblModifyPosition.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblModifyPosition.Name = "lblModifyPosition";
            this.lblModifyPosition.Size = new System.Drawing.Size(116, 30);
            this.lblModifyPosition.TabIndex = 12;
            this.lblModifyPosition.Text = "Stanowisko";
            // 
            // cmbNameModifyPosition
            // 
            this.cmbNameModifyPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNameModifyPosition.FormattingEnabled = true;
            this.cmbNameModifyPosition.Location = new System.Drawing.Point(220, 99);
            this.cmbNameModifyPosition.Name = "cmbNameModifyPosition";
            this.cmbNameModifyPosition.Size = new System.Drawing.Size(165, 25);
            this.cmbNameModifyPosition.TabIndex = 22;
            // 
            // eppositionName
            // 
            this.eppositionName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.eppositionName.ContainerControl = this;
            // 
            // PositionModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.cmbNameModifyPosition);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudModifyMinSalaryPosition);
            this.Controls.Add(this.nudModifyMaxSalaryPosition);
            this.Controls.Add(this.lblMinSalaryModifyPosition);
            this.Controls.Add(this.lblMaxsalaryModifyPosition);
            this.Controls.Add(this.lblNameAddPosition);
            this.Controls.Add(this.pbModifyPosition);
            this.Controls.Add(this.lblModifyPosition);
            this.Name = "PositionModifyForm";
            this.Text = "Modyfikuj stanowisko";
            ((System.ComponentModel.ISupportInitialize)(this.nudModifyMinSalaryPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModifyMaxSalaryPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModifyPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eppositionName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudModifyMinSalaryPosition;
        private System.Windows.Forms.NumericUpDown nudModifyMaxSalaryPosition;
        private System.Windows.Forms.Label lblMinSalaryModifyPosition;
        private System.Windows.Forms.Label lblMaxsalaryModifyPosition;
        private System.Windows.Forms.Label lblNameAddPosition;
        private System.Windows.Forms.PictureBox pbModifyPosition;
        private System.Windows.Forms.Label lblModifyPosition;
        private System.Windows.Forms.ComboBox cmbNameModifyPosition;
        private System.Windows.Forms.ErrorProvider eppositionName;
    }
}