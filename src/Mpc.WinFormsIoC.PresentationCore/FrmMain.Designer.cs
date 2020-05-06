namespace Mpc.WinFormsIoC.PresentationCore
{
    partial class FrmMain
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
            this.userDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuMainGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainConfigurationUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusUserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMainConfigurationCountries = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).BeginInit();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainGeneral,
            this.menuMainConfiguration});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(663, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuMainGeneral
            // 
            this.menuMainGeneral.Name = "menuMainGeneral";
            this.menuMainGeneral.Size = new System.Drawing.Size(107, 20);
            this.menuMainGeneral.Text = "Mpc Application";
            // 
            // menuMainConfiguration
            // 
            this.menuMainConfiguration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainConfigurationCountries,
            this.menuMainConfigurationUsers});
            this.menuMainConfiguration.Name = "menuMainConfiguration";
            this.menuMainConfiguration.Size = new System.Drawing.Size(93, 20);
            this.menuMainConfiguration.Text = "Configuration";
            // 
            // menuMainConfigurationUsers
            // 
            this.menuMainConfigurationUsers.Name = "menuMainConfigurationUsers";
            this.menuMainConfigurationUsers.Size = new System.Drawing.Size(180, 22);
            this.menuMainConfigurationUsers.Text = "Users";
            this.menuMainConfigurationUsers.Click += new System.EventHandler(this.menuMainConfigurationUsers_Click);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusProgressBar,
            this.statusUserLabel,
            this.statusUserName});
            this.statusMain.Location = new System.Drawing.Point(0, 376);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(663, 22);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "statusStrip1";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.MarqueeAnimationSpeed = 0;
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(100, 16);
            this.StatusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // statusUserLabel
            // 
            this.statusUserLabel.Name = "statusUserLabel";
            this.statusUserLabel.Size = new System.Drawing.Size(33, 17);
            this.statusUserLabel.Text = "User:";
            // 
            // statusUserName
            // 
            this.statusUserName.Name = "statusUserName";
            this.statusUserName.Size = new System.Drawing.Size(0, 17);
            // 
            // menuMainConfigurationCountries
            // 
            this.menuMainConfigurationCountries.Name = "menuMainConfigurationCountries";
            this.menuMainConfigurationCountries.Size = new System.Drawing.Size(180, 22);
            this.menuMainConfigurationCountries.Text = "Countries";
            this.menuMainConfigurationCountries.Click += new System.EventHandler(this.menuMainConfigurationCountries_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 398);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Mpc Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userDtoBindingSource;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuMainGeneral;
        private System.Windows.Forms.ToolStripMenuItem menuMainConfiguration;
        private System.Windows.Forms.ToolStripMenuItem menuMainConfigurationUsers;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel statusUserLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusUserName;
        public System.Windows.Forms.ToolStripProgressBar StatusProgressBar;
        private System.Windows.Forms.ToolStripMenuItem menuMainConfigurationCountries;
    }
}

