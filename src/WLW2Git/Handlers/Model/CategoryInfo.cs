namespace WLW2Git.Handlers.Model
{
	using System;

	using CookComputing.XmlRpc;

	[Serializable]
	public class CategoryInfo
	{
		public string categoryid { get; set; }

		public string description { get; set; }

		public string htmlUrl { get; set; }

		[XmlRpcMissingMapping(MappingAction.Ignore)]
		public string parentid { get; set; }

		public string rssUrl { get; set; }

		public string title { get; set; }
	}
}