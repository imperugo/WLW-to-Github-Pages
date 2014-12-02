using System;

namespace WLW2Git.Handlers.Model
{
	[Serializable]
	public class UserInfo
	{
		public string email { get; set; }

		public string firstname { get; set; }

		public string lastname { get; set; }

		public string nickname { get; set; }

		public string url { get; set; }

		public string userid { get; set; }
	}
}