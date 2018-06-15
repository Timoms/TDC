using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threema_Desktop_Client
{
    class LifeSpanHandler : ILifeSpanHandler
    {
        private TDC _instance;

        public LifeSpanHandler(TDC instance)
        {
            _instance = instance;
        }

        public bool DoClose(IWebBrowser browserControl, IBrowser browser)
        {
            //throw new NotImplementedException();
            return false;
        }

        public void OnAfterCreated(IWebBrowser browserControl, IBrowser browser)
        {
            //throw new NotImplementedException();
        }

        public void OnBeforeClose(IWebBrowser browserControl, IBrowser browser)
        {
            //throw new NotImplementedException();
        }

        public bool OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            newBrowser = null;
            if (targetUrl.StartsWith("https://open.spotify.com/track/") || targetUrl.StartsWith("https://play.spotify.com/track/"))
            {
                Spotify spotify = new Spotify(targetUrl, _instance);
                return true;
            } else if (Threema_Desktop_Client.Properties.Settings.Default.defaultbrowser)
            {
                System.Diagnostics.Process.Start(targetUrl);
                return true;
            } else
            {
                _instance.addTabUrl(targetUrl);
                

                _instance.Invoke(new Action(() =>
                {
                    if (_instance.splitContainer1.SplitterDistance == _instance.splitContainer1.Width)
                        _instance.splitContainer1.SplitterDistance = _instance.splitContainer1.Width - 200;
                    else
                        return;
                }));


                return true;
            }
        }

    }
}
