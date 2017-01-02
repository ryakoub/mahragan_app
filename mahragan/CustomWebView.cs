using System;
namespace mahragan
{
	public class CustomWebView1
	{
		public string Name;
		public string pdfFileName { set; get; }

		public CustomWebView1(string name, string filename)
		{
			this.Name = name;
			this.pdfFileName = filename;
		}
		public override string ToString()
		{
			return Name;
		}
	}
}
