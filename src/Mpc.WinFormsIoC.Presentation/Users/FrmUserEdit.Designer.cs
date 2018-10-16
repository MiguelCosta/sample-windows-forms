namespace Mpc.WinFormsIoC.Presentation.Users
{
    partial class FrmUserEdit
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
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(75, 13);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(16, 13);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "Id";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(97, 10);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(255, 20);
            this.TxtId.TabIndex = 1;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(97, 36);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(255, 20);
            this.TxtUsername.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(97, 62);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(255, 20);
            this.TxtPassword.TabIndex = 3;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(97, 88);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(255, 20);
            this.TxtName.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(97, 114);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(255, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(36, 39);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(55, 13);
            this.LblUsername.TabIndex = 6;
            this.LblUsername.Text = "Username";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(38, 65);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 7;
            this.LblPassword.Text = "Password";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(56, 91);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 8;
            this.LblName.Text = "Name";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(59, 117);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 9;
            this.LblEmail.Text = "Email";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(277, 140);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_ClickAsync);
            // 
            // FrmUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(372, 174);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblId);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUserEdit";
            this.Text = "FrmUserEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Button BtnSave;
    }
}