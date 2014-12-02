namespace WLW2Git.Handlers.Model
{
	using System;

	[Serializable]
	public class WpAuthor
	{
		public string display_name { get; set; }

		public string meta_value { get; set; }

		public string user_email { get; set; }

		public int user_id { get; set; }

		public string user_login { get; set; }
	}
}