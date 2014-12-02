using System;
using CookComputing.XmlRpc;

namespace WLW2Git.Handlers.Model
{
	/// <summary>
	/// 	minimal details
	/// </summary>
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public class PageInfo
	{
		public DateTime dateCreated { get; set; }

		public int page_id { get; set; }

		public int page_parent_id { get; set; }

		public string page_title { get; set; }
	}
}