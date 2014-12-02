using System;
using CookComputing.XmlRpc;

namespace WLW2Git.Handlers.Model
{
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public class Page
	{
		public string[] categories { get; set; }

		[XmlRpcMissingMapping(MappingAction.Error)] 
		[XmlRpcMember(Description = "Required when posting.")] 
		public DateTime dateCreated { get; set; }

		public DateTime date_created_gmt { get; set; }

		[XmlRpcMissingMapping(MappingAction.Error)] 
		[XmlRpcMember(Description = "Required when posting.")] 
		public string description { get; set; }

		public string excerpt { get; set; }

		public string link { get; set; }

		public int mt_allow_comments { get; set; }

		public int mt_allow_pings { get; set; }

		public int page_id { get; set; }

		public string page_status { get; set; }

		public string permalink { get; set; }

		public string text_more { get; set; }

		[XmlRpcMissingMapping(MappingAction.Error)] 
		[XmlRpcMember(Description = "Required when posting.")] 
		public string title { get; set; }

		public string user_id { get; set; }

		public string wp_author { get; set; }

		public string wp_author_display_name { get; set; }

		public string wp_author_id { get; set; }

		public string wp_page_order { get; set; }

		// it should have been 'int', but WLW complaining
		public string wp_page_parent_id { get; set; }

		public string wp_page_parent_title { get; set; }

		// it should have been 'int', but WLW complaining

		// array custom_fields
		// struct
		// string id
		// string key
		// string value
		public string wp_page_template { get; set; }

		public string wp_password { get; set; }

		public string wp_slug { get; set; }
	}
}