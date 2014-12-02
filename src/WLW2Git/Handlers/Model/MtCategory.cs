using System;
using CookComputing.XmlRpc;

namespace WLW2Git.Handlers.Model
{
	[Serializable]
	public class MtCategory
	{
		public string categoryId { get; set; }

		[XmlRpcMissingMapping(MappingAction.Ignore)]
		public string categoryName { get; set; }

		[XmlRpcMissingMapping(MappingAction.Ignore)]
		public bool isPrimary { get; set; }
	}
}