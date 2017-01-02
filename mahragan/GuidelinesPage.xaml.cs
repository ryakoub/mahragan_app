using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mahragan
{
	partial class GuidelinesPage : MasterDetailPage
	{
		
		public GuidelinesPage()
		{
			Label header = new Label
			{
				Text = "Guidelines",
				FontSize = 18,
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.Center
			};

			// Asseble an array of CustomWebView
			CustomWebView1[] customWebViews = {
				new CustomWebView1("General" , "index.html"),
				new CustomWebView1("Soccer" , "Soccer-Guidelines-2016.pdf"),
				new CustomWebView1("Basketball" , "Basketball-Guidelines-2016.pdf"),
				new CustomWebView1("Ping Pong" , "Ping-Pong-Guidelines-2016.pdf"),
				new CustomWebView1("Creative Writing" , "Creative-Writing-Guidelines-2016.pdf"),
				new CustomWebView1("Multimedia" , "Multimedia-Guidelines-2016.pdf"),
				new CustomWebView1("Research Paper" , "Research-Paper-Guidelines-2016.pdf"),
				new CustomWebView1("Video Clip" , "Video-Clip-Guidelines-2016.pdf")

			};

			// Create ListView for the master page.
			ListView listView = new ListView
			{
				ItemsSource = customWebViews
			};

			// Create the master page with the ListView.
			this.Master = new ContentPage
			{
				Title = "Guidelines",       // Title required!
				Content = new StackLayout
				{
					Children = {
						header,
						listView
					}
				}
			};

			// Create the detail page using NamedColorPage
			WebViewPage detailPage = new WebViewPage();
			this.Detail = detailPage;

			// For Android & Windows Phone, provide a way to get back to the master page.
			if (Device.OS != TargetPlatform.iOS)
			{
				TapGestureRecognizer tap = new TapGestureRecognizer();
				tap.Tapped += (sender, args) =>
				{
					this.IsPresented = true;
				};

				detailPage.Content.BackgroundColor = Color.Transparent;
				detailPage.Content.GestureRecognizers.Add(tap);
			}

			// Define a selected handler for the ListView.
			listView.ItemSelected += (sender, args) =>
			{
				var item = args.SelectedItem as CustomWebView1;
				if (item != null)
				{
					var pdfView = new WebViewPage();
					pdfView.FindByName<CustomWebView>("PDFFileName").Uri = item.pdfFileName;
					Detail = new NavigationPage(pdfView);
					// Set the BindingContext of the detail page.
					//this.Detail.BindingContext = args.SelectedItem;

					// Show the detail page.
					this.IsPresented = false;
				}
			};

			// Initialize the ListView selection.
			listView.SelectedItem = customWebViews[0];
		}
	}
}