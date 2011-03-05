using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mraSharp
{
	/// <summary>
	/// This class represents an RSS news item. The news item holds data about the title, description, and the link that leads to the topic.
	/// </summary>
	class RssNewsItem
	{
		private string _title;
		private string _link;
		private string _description;

		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				_title = value;
			}
		}

		public string Link
		{
			get
			{
				return _link;
			}
			set
			{
				_link = value;
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}

	}
}
