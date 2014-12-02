namespace WLW2Git.Handlers.Model
{
	using System;

	[Serializable]
	public class WpTagInfo
	{
		public int count { get; set; }

		public string html_url { get; set; }

		public string name { get; set; }

		public string rss_url { get; set; }

		public string slug { get; set; }

		public int tag_id { get; set; }
	}
}