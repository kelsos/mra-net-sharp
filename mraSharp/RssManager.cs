using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;

namespace mraSharp
{
	/// <summary>
	/// This class is responsible for the RSS related operations
	/// </summary>
	class RssManager
	{
		/// <summary>
		/// Processes the news feed.
		/// </summary>
		/// <param name="rssURL">The RSS URL.</param>
		public static ArrayList processNewsFeed(string rssURL)
		{
			ArrayList returnList = new ArrayList();
			try
			{
				WebRequest myRequest = WebRequest.Create(rssURL);
				WebResponse myResponse = myRequest.GetResponse();
				Stream rssStream = myResponse.GetResponseStream();
				XmlDocument rssDoc = new XmlDocument();

				rssDoc.Load(rssStream);

				XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

				foreach (XmlNode currentRssItem in rssItems)
				{
					XmlNode rssDetail;
					RssNewsItem tempNewsItem = new RssNewsItem();

					//Gets the title of the current RSS node.
					rssDetail = currentRssItem.SelectSingleNode("title");
					if (rssDetail != null)
					{
						tempNewsItem.Title = rssDetail.InnerText;
					}
					else
					{
						tempNewsItem.Title = "";
					}

					//Gets the links of the current RSS node.
					rssDetail = currentRssItem.SelectSingleNode("link");
					if (rssDetail != null)
					{
						tempNewsItem.Link = rssDetail.InnerText;
					}
					else
					{
						tempNewsItem.Link = "";
					}

					//Gets the description of the current RSS node.
					rssDetail = currentRssItem.SelectSingleNode("description");
					if (rssDetail !=null)
					{
						tempNewsItem.Description = rssDetail.InnerText;
					}
					else
					{
						tempNewsItem.Description = "";
					}

					//Add the temporary news item to the return ArrayList.
					returnList.Add(tempNewsItem);
				}
			}
			catch (Exception ex)
			{
				Logger.errorLogger("error.txt", ex.ToString());
			}
			return returnList;
		}
	}
}
