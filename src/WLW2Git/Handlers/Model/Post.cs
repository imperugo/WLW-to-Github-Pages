using System;
using CookComputing.XmlRpc;

namespace WLW2Git.Handlers.Model
{
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public class Post
	{
		[XmlRpcMissingMapping(MappingAction.Error)]
		[XmlRpcMember(Description = "Required when posting.")]
		public string[] categories { get; set; }

		public string[] custom_fields { get; set; }

		[XmlRpcMissingMapping(MappingAction.Error)]
		[XmlRpcMember(Description = "Required when posting.")]
		public DateTime dateCreated { get; set; }

		public DateTime date_created_gmt { get; set; }

		[XmlRpcMissingMapping(MappingAction.Error)]
		[XmlRpcMember(Description = "Required when posting.")]
		public string description { get; set; }

		/// <summary>
		/// 	used by metaweblog
		/// </summary>
		public string link { get; set; }

		/// <summary>
		/// 	int enumerated value
		/// 	0 - Default (same as none?)
		/// 	0 - None
		/// 	1 - Open
		/// 	2 - Close
		/// </summary>
		public int mt_allow_comments { get; set; }

		/// <summary>
		/// 	todo: support post updates notification through pinging to various services (like weblogs.com or similar)
		/// </summary>
		public int mt_allow_pings { get; set; }

		/// <summary>
		/// 	todo: implement support
		/// </summary>
		public string mt_convert_breaks { get; set; }

		public string mt_excerpt { get; set; }

		/// <summary>
		/// 	contains a list of tags passed from WLW
		/// </summary>
		public string mt_keywords { get; set; }

		public string mt_text_more { get; set; }

		/// <summary>
		/// 	used by metaweblog
		/// </summary>
		public string permalink { get; set; }

		public string post_status { get; set; }

		public string postid { get; set; }

		public bool sticky { get; set; }

		[XmlRpcMissingMapping(MappingAction.Error)]
		[XmlRpcMember(Description = "Required when posting.")]
		public string title { get; set; }

		/// <summary>
		/// 	used by metaweblog
		/// </summary>
		public string userid { get; set; }

		/// <summary>
		/// 	username of the author of the post
		/// </summary>
		public string wp_author_display_name { get; set; }

		/// <summary>
		/// 	id of the post author (used by wlw)
		/// 
		/// 	null or empty means [Default] in wlw
		/// </summary>
		public string wp_author_id { get; set; }

		public string wp_password { get; set; }

		public string wp_slug { get; set; }
	}
}