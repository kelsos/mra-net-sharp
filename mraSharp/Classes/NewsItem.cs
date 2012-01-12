using System;

namespace mraSharp.Classes
{
    /// <summary>
    /// This class represents an RSS news item. The news item holds data about the title, description, and the link that leads to the topic.
    /// </summary>
    internal class NewsItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewsItem"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="link">The link.</param>
        /// <param name="description">The description.</param>
        /// <param name="publicationDate">The publication date.</param>
        public NewsItem(string title, string link, string description, DateTime publicationDate)
        {
            Title = title;
            Link = link;
            Description = description;
            AquisitionDate = publicationDate;
        }

        public NewsItem()
        {
            Title = "";
            Link = "";
            Description = "";
            AquisitionDate = null;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        /// <value>
        /// The link.
        /// </value>
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the publication date.
        /// </summary>
        /// <value>
        /// The publication date.
        /// </value>
        public DateTime? AquisitionDate { get; set; }
    }
}