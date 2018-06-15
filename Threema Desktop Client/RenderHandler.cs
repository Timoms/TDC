using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threema_Desktop_Client
{
    class RenderHandler : IRenderProcessMessageHandler
    {
        public void OnContextCreated(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {
        
        }

        public void OnContextReleased(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {
        }

        public void OnFocusedNodeChanged(IWebBrowser browserControl, IBrowser browser, IFrame frame, IDomNode node)
        {
        }
    }
}
