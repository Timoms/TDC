namespace Threema_Desktop_Client
{
    partial class TDC
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TDC));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.newTabPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newTabCloseButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.newTabOpenInBrowserButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.newTabPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Threema";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.newTabPanel);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // newTabPanel
            // 
            this.newTabPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.newTabPanel.ColumnCount = 1;
            this.newTabPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.newTabPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newTabPanel.Location = new System.Drawing.Point(0, 0);
            this.newTabPanel.Name = "newTabPanel";
            this.newTabPanel.RowCount = 2;
            this.newTabPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.newTabPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.newTabPanel.Size = new System.Drawing.Size(530, 450);
            this.newTabPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.newTabOpenInBrowserButton);
            this.flowLayoutPanel1.Controls.Add(this.newTabCloseButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 11);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // newTabCloseButton
            // 
            this.newTabCloseButton.Depth = 0;
            this.newTabCloseButton.Location = new System.Drawing.Point(3, 32);
            this.newTabCloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.newTabCloseButton.Name = "newTabCloseButton";
            this.newTabCloseButton.Primary = true;
            this.newTabCloseButton.Size = new System.Drawing.Size(66, 23);
            this.newTabCloseButton.TabIndex = 0;
            this.newTabCloseButton.Text = "Close";
            this.newTabCloseButton.UseVisualStyleBackColor = true;
            this.newTabCloseButton.Click += new System.EventHandler(this.newTabCloseButton_Click);
            // 
            // newTabOpenInBrowserButton
            // 
            this.newTabOpenInBrowserButton.Depth = 0;
            this.newTabOpenInBrowserButton.Location = new System.Drawing.Point(3, 3);
            this.newTabOpenInBrowserButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.newTabOpenInBrowserButton.Name = "newTabOpenInBrowserButton";
            this.newTabOpenInBrowserButton.Primary = true;
            this.newTabOpenInBrowserButton.Size = new System.Drawing.Size(133, 23);
            this.newTabOpenInBrowserButton.TabIndex = 1;
            this.newTabOpenInBrowserButton.Text = "Open in Browser";
            this.newTabOpenInBrowserButton.UseVisualStyleBackColor = true;
            this.newTabOpenInBrowserButton.Click += new System.EventHandler(this.newTabOpenInBrowserButton_Click);
            // 
            // TDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TDC";
            this.Text = "Threema Web";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TDC_FormClosing);
            this.Load += new System.EventHandler(this.TDC_Load);
            this.Enter += new System.EventHandler(this.TDC_Enter);
            this.Resize += new System.EventHandler(this.TDC_Resize);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.newTabPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialRaisedButton newTabCloseButton;
        private MaterialSkin.Controls.MaterialRaisedButton newTabOpenInBrowserButton;
        public System.Windows.Forms.TableLayoutPanel newTabPanel;
        public System.Windows.Forms.SplitContainer splitContainer1;
    }
}

