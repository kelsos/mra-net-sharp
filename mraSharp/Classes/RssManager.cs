using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Xml;

namespace mraSharp
{
	/// <summary>
	/// This class is responsible for the RSS related operations
	/// </summary>
	internal class RssManager
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
					NewsItem tempNewsItem = new NewsItem();

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
					if (rssDetail != null)
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
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
			return returnList;
		}
	}
}