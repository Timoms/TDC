using CefSharp;
using CefSharp.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;
using SpotifyAPI.Web; //Base Namespace
using SpotifyAPI.Web.Auth; //All Authentication-related classes
using SpotifyAPI.Web.Enums; //Enums
using SpotifyAPI.Web.Models; //Models for the JSON-responses
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Threema_Desktop_Client
{
    // okay also du willst ein ui lement von hier accessen notifyicon right?

    public partial class TDC : Form
    {

        public static MaterialLabel notificationLabel;
        internal static bool canReceiveNotifications = false;
        private readonly ChromiumWebBrowser browser;
        private ChromiumWebBrowser newTab;

        public TDC()
        {
            InitializeComponent();
            Size = new Size(Threema_Desktop_Client.Properties.Settings.Default.width, Threema_Desktop_Client.Properties.Settings.Default.height);
            CenterToScreen();

            CefSettings s = new CefSettings()
            {
                Locale = "de"
            };


            s.SetOffScreenRenderingBestPerformanceArgs();
            s.CachePath = "cache";
            s.RemoteDebuggingPort = 8088;


            if (!Cef.IsInitialized)
                Cef.Initialize(s);

            

            browser = new ChromiumWebBrowser("https://web.threema.ch/")
            {
                Dock = DockStyle.Fill,
            };


            
            
            

            browser.RenderProcessMessageHandler = new RenderHandler();
            browser.RequestHandler = new RequestHandle(this);
            browser.LifeSpanHandler = new LifeSpanHandler(this);


            browser.TitleChanged += OnBrowserTitleChanged;

            browser.FrameLoadEnd += (sender, args) =>
            {
                if (args.Url.StartsWith("https://web.threema.ch/"))
                {
                    if (args.Frame.IsMain)
                    {
                        if (!(Properties.Settings.Default.password.Length == 0) && Properties.Settings.Default.autologin != false)
                            args.Frame.ExecuteJavaScriptAsync((Properties.Resources.Threema.Replace("password_", Properties.Settings.Default.password)));
                    }
                }

            };
            splitContainer1.Panel1.Controls.Add(browser);
            splitContainer1.SplitterDistance = splitContainer1.Width;

            //Controls.Add(browser);

        }

        internal void addTabUrl(string targetUrl)
        {
            if (newTab == null)
            {
                newTab = new ChromiumWebBrowser(targetUrl);
                

                Invoke(new Action(() =>
                {
                    newTabPanel.Controls.Add(newTab, 0, 1);
                    splitContainer1.SplitterDistance = splitContainer1.Width - 450;
                }));

            }
            else
                newTab.GetMainFrame().LoadUrl(targetUrl);
        }

        public void OnBrowserTitleChanged(object sender, TitleChangedEventArgs e)
        {

            if (!canReceiveNotifications || this.Text.Equals(e.Title) || (TDC.ActiveForm == this))
                return;

            if (Threema_Desktop_Client.Properties.Settings.Default.notifications)
            {
                this.Invoke(new Action(() =>
                {
                    Text = e.Title;
                    trayIcon.BalloonTipTitle = e.Title;
                    trayIcon.BalloonTipText = "New Message";
                    trayIcon.BalloonTipIcon = ToolTipIcon.Info;
                    trayIcon.ShowBalloonTip(2500);
                }));
            }

        }

        private void TDC_Load(object sender, EventArgs e)
        {
            //-v-Debugging Field-v-\\
            //Spotify spotify = new Spotify("https://open.spotify.com/track/3Wn52FjoUJClQOXwKePPp3?si=9KoHlNyXTA2sUnLHH1cXcA");
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Visible = true;
            Show();
        }

        private void TDC_Resize(object sender, EventArgs e)
        {
            Threema_Desktop_Client.Properties.Settings.Default.height = this.Size.Height;
            Threema_Desktop_Client.Properties.Settings.Default.width = this.Size.Width;
            Threema_Desktop_Client.Properties.Settings.Default.Save();
        }

        private void TDC_Enter(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            trayIcon.Visible = true;
        }

        private void newTabCloseButton_Click(object sender, EventArgs e)
        {
            newTab.Stop();
            splitContainer1.SplitterDistance = splitContainer1.Width;
        }

        private void newTabOpenInBrowserButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(newTab.GetMainFrame().Url);
        }

        private void TDC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Threema_Desktop_Client.Properties.Settings.Default.closetotray)
            {
                e.Cancel = true;
                new CancelEventArgs().Cancel = true;
                Visible = false;
            }

            e.Cancel = false;
            new CancelEventArgs().Cancel = false;
        }
    }
}
