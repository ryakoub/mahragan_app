using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mahragan
{
	public partial class SpiritualBooksPage : ContentPage
	{
		public SpiritualBooksPage()
		{
			InitializeComponent();
		}
		async void displayPDF(object sender, EventArgs e) 
		{
			Button senderButton = (Button)sender;
			string bookName = senderButton.StyleId;
			string filename = "03_Gr_3_4_Final_2016.pdf";
			switch (bookName)
			{
				case "kg":
					filename = "01_Kindergarten_Final_2016.pdf";
					break;
				case "gr12":	
					filename = "02_Gr_1_2_Final_2016.pdf";
					break;
				case "gr34":
					filename = "03_Gr_3_4_Final_2016.pdf";
					break;
				case "gr56":
					filename = "04_Gr_5_6_Final_2016.pdf";
					break;
				case "gr78":
					filename = "05_Gr_7_8_Final_2016.pdf";
					break;
				case "gr912":
					filename = "06_Gr_9_12_Final_2016.pdf";
					break;
				default:
					filename = "06_Gr_9_12_Final_2016.pdf";
					break;
			}

			var pdfView = new WebViewPage();
			pdfView.FindByName<CustomWebView>("PDFFileName").Uri = filename;
			await Navigation.PushAsync(pdfView); 
		}
	}

	public class CustomWebView : WebView
	{
		public static readonly BindableProperty UriProperty = BindableProperty.Create(propertyName: "Uri",
						returnType: typeof(string),
						declaringType: typeof(CustomWebView),
						defaultValue: default(string));

		public string Uri
		{
			get { return (string)GetValue(UriProperty); }
			set { SetValue(UriProperty, value); }
		}
	}
}
