using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using mahragan;
using mahragan.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System.IO;
using System.Net;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]

namespace mahragan.Droid
{
	[Activity(Label = "mahragan.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());
		}
	}
	public class CustomWebViewRenderer : WebViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null)
			{
				var customWebView = Element as CustomWebView;
				Control.Settings.AllowUniversalAccessFromFileURLs = true;
				string pdfFileName = string.Format("file:///android_asset/PDFBooks/{0}", WebUtility.UrlEncode(customWebView.Uri));
				string urlFileName = string.Format("file:///android_asset/pdfjs/web/viewer.html?file={0}", pdfFileName);
				Control.LoadUrl(urlFileName);
			}
		}
	}
}
