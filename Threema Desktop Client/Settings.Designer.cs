namespace Threema_Desktop_Client
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.notificationCB = new MaterialSkin.Controls.MaterialCheckBox();
            this.linksCB = new MaterialSkin.Controls.MaterialCheckBox();
            this.defaultBrowserCB = new MaterialSkin.Controls.MaterialCheckBox();
            this.autologinCB = new MaterialSkin.Controls.MaterialCheckBox();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.closeToTrayCB = new MaterialSkin.Controls.MaterialCheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.notificationCB);
            this.flowLayoutPanel1.Controls.Add(this.linksCB);
            this.flowLayoutPanel1.Controls.Add(this.closeToTrayCB);
            this.flowLayoutPanel1.Controls.Add(this.defaultBrowserCB);
            this.flowLayoutPanel1.Controls.Add(this.autologinCB);
            this.flowLayoutPanel1.Controls.Add(this.passwordLabel);
            this.flowLayoutPanel1.Controls.Add(this.passwordInput);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(256, 449);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // notificationCB
            // 
            this.notificationCB.AutoSize = true;
            this.notificationCB.Depth = 0;
            this.notificationCB.Font = new System.Drawing.Font("Roboto", 10F);
            this.notificationCB.Location = new System.Drawing.Point(0, 0);
            this.notificationCB.Margin = new System.Windows.Forms.Padding(0);
            this.notificationCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.notificationCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.notificationCB.Name = "notificationCB";
            this.notificationCB.Ripple = true;
            this.notificationCB.Size = new System.Drawing.Size(109, 30);
            this.notificationCB.TabIndex = 2;
            this.notificationCB.Text = "Notifications";
            this.notificationCB.UseVisualStyleBackColor = true;
            this.notificationCB.CheckedChanged += new System.EventHandler(this.notificationCB_CheckedChanged);
            // 
            // linksCB
            // 
            this.linksCB.AutoSize = true;
            this.linksCB.BackColor = System.Drawing.SystemColors.Control;
            this.linksCB.Depth = 0;
            this.linksCB.Font = new System.Drawing.Font("Roboto", 10F);
            this.linksCB.Location = new System.Drawing.Point(0, 30);
            this.linksCB.Margin = new System.Windows.Forms.Padding(0);
            this.linksCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.linksCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.linksCB.Name = "linksCB";
            this.linksCB.Ripple = true;
            this.linksCB.Size = new System.Drawing.Size(238, 30);
            this.linksCB.TabIndex = 3;
            this.linksCB.Text = "Play Spotify links without opening";
            this.linksCB.UseVisualStyleBackColor = false;
            this.linksCB.CheckedChanged += new System.EventHandler(this.linksCB_CheckedChanged);
            // 
            // defaultBrowserCB
            // 
            this.defaultBrowserCB.AutoSize = true;
            this.defaultBrowserCB.BackColor = System.Drawing.SystemColors.Control;
            this.defaultBrowserCB.Depth = 0;
            this.defaultBrowserCB.Font = new System.Drawing.Font("Roboto", 10F);
            this.defaultBrowserCB.Location = new System.Drawing.Point(0, 90);
            this.defaultBrowserCB.Margin = new System.Windows.Forms.Padding(0);
            this.defaultBrowserCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.defaultBrowserCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.defaultBrowserCB.Name = "defaultBrowserCB";
            this.defaultBrowserCB.Ripple = true;
            this.defaultBrowserCB.Size = new System.Drawing.Size(213, 30);
            this.defaultBrowserCB.TabIndex = 7;
            this.defaultBrowserCB.Text = "Open Links in default browser";
            this.defaultBrowserCB.UseVisualStyleBackColor = false;
            this.defaultBrowserCB.CheckedChanged += new System.EventHandler(this.defaultBrowserCB_CheckedChanged);
            // 
            // autologinCB
            // 
            this.autologinCB.AutoSize = true;
            this.autologinCB.BackColor = System.Drawing.SystemColors.Control;
            this.autologinCB.Depth = 0;
            this.autologinCB.Font = new System.Drawing.Font("Roboto", 10F);
            this.autologinCB.Location = new System.Drawing.Point(0, 120);
            this.autologinCB.Margin = new System.Windows.Forms.Padding(0);
            this.autologinCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.autologinCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.autologinCB.Name = "autologinCB";
            this.autologinCB.Ripple = true;
            this.autologinCB.Size = new System.Drawing.Size(98, 30);
            this.autologinCB.TabIndex = 6;
            this.autologinCB.Text = "Auto-Login";
            this.autologinCB.UseVisualStyleBackColor = false;
            this.autologinCB.CheckedChanged += new System.EventHandler(this.autologinCB_CheckedChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordLabel.Location = new System.Drawing.Point(3, 150);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(231, 19);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Threema Web Restore Password:";
            // 
            // passwordInput
            // 
            this.passwordInput.Depth = 0;
            this.passwordInput.Hint = "";
            this.passwordInput.Location = new System.Drawing.Point(3, 172);
            this.passwordInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '\0';
            this.passwordInput.SelectedText = "";
            this.passwordInput.SelectionLength = 0;
            this.passwordInput.SelectionStart = 0;
            this.passwordInput.Size = new System.Drawing.Size(253, 23);
            this.passwordInput.TabIndex = 4;
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordInput_KeyDown);
            this.passwordInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwordInput_KeyUp);
            // 
            // closeToTrayCB
            // 
            this.closeToTrayCB.AutoSize = true;
            this.closeToTrayCB.BackColor = System.Drawing.SystemColors.Control;
            this.closeToTrayCB.Depth = 0;
            this.closeToTrayCB.Font = new System.Drawing.Font("Roboto", 10F);
            this.closeToTrayCB.Location = new System.Drawing.Point(0, 60);
            this.closeToTrayCB.Margin = new System.Windows.Forms.Padding(0);
            this.closeToTrayCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.closeToTrayCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeToTrayCB.Name = "closeToTrayCB";
            this.closeToTrayCB.Ripple = true;
            this.closeToTrayCB.Size = new System.Drawing.Size(107, 30);
            this.closeToTrayCB.TabIndex = 8;
            this.closeToTrayCB.Text = "Close to tray";
            this.closeToTrayCB.UseVisualStyleBackColor = false;
            this.closeToTrayCB.CheckedChanged += new System.EventHandler(this.closeToTrayCB_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(256, 449);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialCheckBox linksCB;
        private MaterialSkin.Controls.MaterialCheckBox notificationCB;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordInput;
        private MaterialSkin.Controls.MaterialCheckBox autologinCB;
        private MaterialSkin.Controls.MaterialCheckBox defaultBrowserCB;
        private MaterialSkin.Controls.MaterialCheckBox closeToTrayCB;
    }
}