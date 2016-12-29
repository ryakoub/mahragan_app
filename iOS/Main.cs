using System;
using System.Collections.Generic;
using System.Linq;
using mahragan;
using Foundation;
using UIKit;
using mahragan.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.IO;
using System.Net;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace mahragan.iOS
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main(string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main(args, null, "AppDelegate");
		}
	}

	public class CustomWebViewRenderer : ViewRenderer<CustomWebView, UIWebView>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<CustomWebView> e)
		{
			base.OnElementChanged(e);

			if (Control == null)
			{
				SetNativeControl(new UIWebView());
			}
			if (e.OldElement != null)
			{
				// Cleanup
			}
			if (e.NewElement != null)
			{
				var customWebView = Element as CustomWebView;
				string fileName = Path.Combine(NSBundle.MainBundle.BundlePath, string.Format("PDFBooks/{0}", WebUtility.UrlEncode(customWebView.Uri)));
				Control.LoadRequest(new NSUrlRequest(new NSUrl(fileName, false)));
				Control.ScalesPageToFit = true;
			}
		}
	}
}
