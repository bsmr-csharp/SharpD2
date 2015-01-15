﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xilium.CefGlue;

namespace SharpDX.Toolkit.CefGlue
{
    public class SharpDXCefLoadHandler : CefLoadHandler
    {
        private SharpDXCefBrowser _owner;

        public SharpDXCefLoadHandler(SharpDXCefBrowser owner)
        {
            this._owner = owner;
        }

        protected override void OnLoadingStateChange(CefBrowser browser, bool isLoading, bool canGoBack, bool canGoForward)
        {
            this._owner.OnLoadingStateChange(isLoading, canGoBack, canGoForward);
        }

        protected override void OnLoadError(CefBrowser browser, CefFrame frame, CefErrorCode errorCode, string errorText, string failedUrl)
        {
            this._owner.OnLoadError(frame, errorCode, errorText, failedUrl);
        }

        protected override void OnLoadStart(CefBrowser browser, CefFrame frame)
        {
            this._owner.OnLoadStart(frame);
        }

        protected override void OnLoadEnd(CefBrowser browser, CefFrame frame, int httpStatusCode)
        {
            this._owner.OnLoadEnd(frame, httpStatusCode);
        }
    }
}
