using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mahragan
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
			//header box & label
			var header = new Label
			{
				Text = "St. Mark Festival\nChicago Land and Midwest Coptic Churches\nمهرجان الكرازة",
				LineBreakMode = LineBreakMode.WordWrap,
				HorizontalTextAlignment=TextAlignment.Center,
				TextColor=Color.White,
				FontSize = 18
			};

			var headerBox = new BoxView { Color = Color.Maroon };
			AbsoluteLayout.SetLayoutBounds(headerBox, new Rectangle(0, 0, 1, .12));
			AbsoluteLayout.SetLayoutFlags(headerBox, AbsoluteLayoutFlags.All);

			AbsoluteLayout.SetLayoutBounds(header, new Rectangle(0, 0, 1, .12));
			AbsoluteLayout.SetLayoutFlags(header, AbsoluteLayoutFlags.All);

			//footer box & label
			var footer = new Label
			{
				Text = "Taste & See (Psalm 34:8)",
				LineBreakMode = LineBreakMode.WordWrap,
				HorizontalTextAlignment = TextAlignment.Center,
				TextColor = Color.White
			};

			var footerBox = new BoxView { Color = Color.Maroon };
			AbsoluteLayout.SetLayoutBounds(footerBox, new Rectangle(0, 1.0, 1, .05));
			AbsoluteLayout.SetLayoutFlags(footerBox, AbsoluteLayoutFlags.All);

			AbsoluteLayout.SetLayoutBounds(footer, new Rectangle(0, 1.0, 1, .05));
			AbsoluteLayout.SetLayoutFlags(footer, AbsoluteLayoutFlags.All);

			// add contents to layout
			absoluteLOforHeader.Children.Add(headerBox);
			absoluteLOforHeader.Children.Add(header);
			absoluteLOforHeader.Children.Add(footerBox);
			absoluteLOforHeader.Children.Add(footer);
		}
		async void getBooksView(object sender, EventArgs e) { await Navigation.PushAsync(new SpiritualBooksPage()); }
		async void getHymnsView(object sender, EventArgs e) { await Navigation.PushAsync(new HymnsPage()); }
		async void getGuidelinesView(object sender, EventArgs e) { await Navigation.PushAsync(new GuidelinesPage()); }
	}
}
