namespace WLW2Git.Handlers.Model
{
	using System;

	[Serializable]
	public class WpCategoryInfo
	{
		public int categoryId { get; set; }

		public string categoryName { get; set; }

		public string description { get; set; }

		public string htmlUrl { get; set; }

		public int parentId { get; set; }

		public string rssUrl { get; set; }
	}
}