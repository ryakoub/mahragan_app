using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mahragan
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
			masterpage.ListView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				if (item.FileName != null)
				{
					var pdfView = new WebViewPage();
					pdfView.FindByName<CustomWebView>("PDFFileName").Uri = item.FileName;
					Detail = new NavigationPage(pdfView);

				}
				else {
					Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				}
				masterpage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}
