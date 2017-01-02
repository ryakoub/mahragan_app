using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mahragan
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage()
		{
			InitializeComponent();

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Home",
				IconSource = "Midwest_logo.png",
				TargetType = typeof(HomePage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Spiritual Books",
				IconSource = "spiritualBooks",
				TargetType = typeof(SpiritualBooksPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Hymns",
				IconSource = "cymbalsicon.jpg",
				TargetType = typeof(HymnsPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Coptic",
				IconSource = "alpha.png",
				TargetType = typeof(HymnsPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Guidelines",
				IconSource = "guidelines.jpeg",
				TargetType = typeof(GuidelinesPage)
			});
			/*
			masterPageItems.Add(new MasterPageItem
			{
				Title = "General",
				IconSource = "guidelines.jpeg",
				FileName = "index.html",
				TargetType = typeof(WebViewPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Ping Pong",
				IconSource = "Table_tennis-512.png",
				FileName = "Ping-Pong-Guidelines-2016.pdf",
				TargetType = typeof(WebViewPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Basketball",
				IconSource = "basketball.ico",
				FileName = "Basketball-Guidelines-2016.pdf",
				TargetType = typeof(WebViewPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Soccer",
				IconSource = "Artua-Soccer-Football.ico",
				FileName = "Soccer-Guidelines-2016.pdf",
				TargetType = typeof(WebViewPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Research Paper",
				IconSource = "paper.jpeg",
				FileName = "Research-Paper-Guidelines-2016.pdf",
				TargetType = typeof(WebViewPage)
			});
      */
			listView.ItemsSource = masterPageItems;
		}
	}
	public class MasterPageItem
	{
		public string Title { get; set; }

		public string IconSource { get; set; }

		public Type TargetType { get; set; }

		public string FileName { get; set;}
	}
}
