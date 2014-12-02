using System;
using CookComputing.XmlRpc;

namespace WLW2Git.Handlers.Model
{
	[Serializable]
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public class WpNewCategory
	{
		public string description { get; set; }

		public string name { get; set; }

		public int parent_id { get; set; }

		public string slug { get; set; }
	}
}