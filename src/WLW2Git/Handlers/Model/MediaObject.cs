namespace WLW2Git.Handlers.Model
{
	using CookComputing.XmlRpc;

	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public class MediaObject
	{
		public byte[] bits { get; set; }

		public string name { get; set; }

		public string type { get; set; }
	}
}