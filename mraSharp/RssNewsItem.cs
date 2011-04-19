namespace mraSharp
{
	/// <summary>
	/// This class represents an RSS news item. The news item holds data about the title, description, and the link that leads to the topic.
	/// </summary>
	internal class RssNewsItem
	{
		private string _title;
		private string _link;
		private string _description;

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>
		/// The title.
		/// </value>
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

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>
		/// The link.
		/// </value>
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

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
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