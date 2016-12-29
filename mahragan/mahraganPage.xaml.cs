using System;
using Xamarin.Forms;

namespace mahragan
{
	public partial class mahraganPage : ContentPage
	{
		public mahraganPage()
		{
			InitializeComponent();
			//header label
			var header = new Label
			{
				Text = "St. Mark Festival.\nChicago Land and Midwest Coptic Churches.",
				LineBreakMode = LineBreakMode.WordWrap,
				BackgroundColor = Color.Maroon,
				HorizontalOptions=LayoutOptions.Center
			};

			AbsoluteLayout.SetLayoutBounds(header, new Rectangle(0, 0, 1, .1));
			AbsoluteLayout.SetLayoutFlags(header, AbsoluteLayoutFlags.All);
			absoluteLOforHeader.Children.Add(header);
		}

		async void getBooksView(object sender, EventArgs e) { await Navigation.PushAsync(new SpiritualBooksPage()); }
		async void getHymnsView(object sender, EventArgs e) { await Navigation.PushAsync(new HymnsPage()); }
	}
}
