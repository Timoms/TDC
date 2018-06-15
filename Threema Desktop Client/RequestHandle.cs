using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threema_Desktop_Client
{

    class RequestHandle : IRequestHandler
    {
        private TDC _instance;

        public RequestHandle(TDC instance)
        {
            _instance = instance;
        }

        public bool GetAuthCredentials(IWebBrowser browserControl, IBrowser browser, IFrame frame, bool isProxy, string host, int port, string realm, string scheme, IAuthCallback callback)
        {
            //throw new NotImplementedException();
            return false;
        }

        public IResponseFilter GetResourceResponseFilter(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response)
        {
            //throw new NotImplementedException();
            return null;
        }

        public bool OnBeforeBrowse(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, bool isRedirect)
        {
            // -- Link Handler for e.g. Spotify Links
            if (request.Url.StartsWith("https://open.spotify.com/track/") || request.Url.StartsWith("https://play.spotify.com/track/"))
            {
                browserControl.Stop();
                Spotify spotify = new Spotify(request.Url, _instance);
            } else if (request.Url.StartsWith("https://web.threema.ch/"))
            {
                return false;
            }

            else {
                if (Properties.Settings.Default.defaultbrowser)
                {
                    System.Diagnostics.Process.Start(request.Url);
                    return true;
                }
                return false;
                
            }
            return false;
        }

        public CefReturnValue OnBeforeResourceLoad(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback)
        {
            
            //throw new NotImplementedException();
            return CefReturnValue.Continue;
        }



        public bool OnCertificateError(IWebBrowser browserControl, IBrowser browser, CefErrorCode errorCode, string requestUrl, ISslInfo sslInfo, IRequestCallback callback)
        {
            //throw new NotImplementedException();
            return false;
        }


        public bool OnOpenUrlFromTab(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, WindowOpenDisposition targetDisposition, bool userGesture)
        {
            return true;
        }

        public void OnPluginCrashed(IWebBrowser browserControl, IBrowser browser, string pluginPath)
        {
            //throw new NotImplementedException();
        }

        public bool OnProtocolExecution(IWebBrowser browserControl, IBrowser browser, string url)
        {
            //throw new NotImplementedException();
            return false;
        }

        public bool OnQuotaRequest(IWebBrowser browserControl, IBrowser browser, string originUrl, long newSize, IRequestCallback callback)
        {
            //throw new NotImplementedException();
            return false;
        }

        public void OnRenderProcessTerminated(IWebBrowser browserControl, IBrowser browser, CefTerminationStatus status)
        {
            //throw new NotImplementedException();
        }

        public void OnRenderViewReady(IWebBrowser browserControl, IBrowser browser)
        {
            TDC.canReceiveNotifications = true; 
        }

        public void OnResourceLoadComplete(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response, UrlRequestStatus status, long receivedContentLength)
        {

        }

        public void OnResourceRedirect(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response, ref string newUrl)
        {
            //throw new NotImplementedException();
        }

        public bool OnResourceResponse(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response)
        {
            //throw new NotImplementedException();
            return false;
        }

        public bool OnSelectClientCertificate(IWebBrowser browserControl, IBrowser browser, bool isProxy, string host, int port, X509Certificate2Collection certificates, ISelectClientCertificateCallback callback)
        {
            //throw new NotImplementedException();
            return false;
        }
      
    }
}
