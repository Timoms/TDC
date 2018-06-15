using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threema_Desktop_Client
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            passwordInput.Text = Threema_Desktop_Client.Properties.Settings.Default.password;
            linksCB.Checked = Threema_Desktop_Client.Properties.Settings.Default.linklistener;
            notificationCB.Checked = Threema_Desktop_Client.Properties.Settings.Default.notifications;
            defaultBrowserCB.Checked = Threema_Desktop_Client.Properties.Settings.Default.defaultbrowser;
            autologinCB.Checked = Threema_Desktop_Client.Properties.Settings.Default.autologin;
            closeToTrayCB.Checked = Threema_Desktop_Client.Properties.Settings.Default.closetotray;


            if (autologinCB.Checked)
                passwordInput.Enabled = true;
            else if (!autologinCB.Checked)
                passwordInput.Enabled = false;

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void linksCB_CheckedChanged(object sender, EventArgs e)
        {
            Threema_Desktop_Client.Properties.Settings.Default.linklistener = linksCB.Checked;
            Threema_Desktop_Client.Properties.Settings.Default.Save();
        }

        private void notificationCB_CheckedChanged(object sender, EventArgs e)
        {
            Threema_Desktop_Client.Properties.Settings.Default.notifications = notificationCB.Checked;
            Threema_Desktop_Client.Properties.Settings.Default.Save();

        }

        private void passwordInput_KeyDown(object sender, KeyEventArgs e)
        {
            Threema_Desktop_Client.Properties.Settings.Default.password = passwordInput.Text;
            Threema_Desktop_Client.Properties.Settings.Default.Save();
        }

        private void passwordInput_KeyUp(object sender, KeyEventArgs e)
        {
            Threema_Desktop_Client.Properties.Settings.Default.password = passwordInput.Text;
            Threema_Desktop_Client.Properties.Settings.Default.Save();
        }

        private void autologinCB_CheckedChanged(object sender, EventArgs e)
        {
            if (autologinCB.Checked)
                passwordInput.Enabled = true;
            else if (!autologinCB.Checked)
                passwordInput.Enabled = false;

            Threema_Desktop_Client.Properties.Settings.Default.autologin = autologinCB.Checked;
            Threema_Desktop_Client.Properties.Settings.Default.Save();
        }

        private void defaultBrowserCB_CheckedChanged(object sender, EventArgs e)
        {
            Threema_Desktop_Client.Properties.Settings.Default.defaultbrowser = defaultBrowserCB.Checked;
            Threema_Desktop_Client.Properties.Settings.Default.Save();
        }

        private void closeToTrayCB_CheckedChanged(object sender, EventArgs e)
        {
            Threema_Desktop_Client.Properties.Settings.Default.closetotray = closeToTrayCB.Checked;
            Threema_Desktop_Client.Properties.Settings.Default.Save();
        }
    }
}
