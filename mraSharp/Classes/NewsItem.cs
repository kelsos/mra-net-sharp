using System;

namespace mraSharp
{
	/// <summary>
	/// This class represents an RSS news item. The news item holds data about the title, description, and the link that leads to the topic.
	/// </summary>
	internal class NewsItem
	{
		private string _title;
		private string _link;
		private string _description;
		private DateTime _publicationDate;

		/// <summary>
		/// Initializes a new instance of the <see cref="NewsItem"/> class.
		/// </summary>
		/// <param name="title">The title.</param>
		/// <param name="link">The link.</param>
		/// <param name="description">The description.</param>
		/// <param name="publicationDate">The publication date.</param>
		public NewsItem(string title, string link, string description, DateTime publicationDate)
		{
			_title = title;
			_link = link;
			_description = description;
			_publicationDate = publicationDate;
		}

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>
		/// The title.
		/// </value>
		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		/// <summary>
		/// Gets or sets the link.
		/// </summary>
		/// <value>
		/// The link.
		/// </value>
		public string Link
		{
			get { return _link; }
			set { _link = value; }
		}

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Gets or sets the publication date.
		/// </summary>
		/// <value>
		/// The publication date.
		/// </value>
		public DateTime PublicationDate
		{
			get { return _publicationDate; }
			set { _publicationDate = value; }
		}
	}
}