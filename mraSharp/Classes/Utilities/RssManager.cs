﻿using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Xml;
using mraNet.Classes.Data;
using mraNet.Forms;

namespace mraNet.Classes.Utilities
{
    /// <summary>
    /// This class is responsible for the RSS related operations
    /// </summary>
    internal class RssManager
    {
        /// <summary>
        /// Processes the news feed.
        /// </summary>
        /// <param name="subscriptionUrl">The RSS URL.</param>
        public static ArrayList ProcessNewsFeed(string subscriptionUrl)
        {
            if (subscriptionUrl == null) throw new ArgumentNullException("subscriptionUrl");
            ArrayList returnList = new ArrayList();
            try
            {
                WebRequest myRequest = WebRequest.Create(subscriptionUrl);
                WebResponse myResponse = myRequest.GetResponse();
                Stream rssStream = myResponse.GetResponseStream();
                XmlDocument rssDoc = new XmlDocument();

                if (rssStream != null) rssDoc.Load(rssStream);

                XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

                if (rssItems != null)
                    foreach (XmlNode currentRssItem in rssItems)
                    {
                        var tempNewsItem = new NewsItem();

                        //Gets the title of the current RSS node.
                        XmlNode rssDetail = currentRssItem.SelectSingleNode("title");
                        tempNewsItem.Title = rssDetail != null ? rssDetail.InnerText : "";

                        //Gets the links of the current RSS node.
                        rssDetail = currentRssItem.SelectSingleNode("link");
                        tempNewsItem.Link = rssDetail != null ? rssDetail.InnerText : "";

                        //Gets the description of the current RSS node.
                        rssDetail = currentRssItem.SelectSingleNode("description");
                        tempNewsItem.Description = rssDetail != null ? rssDetail.InnerText : "";

                        //Add the temporary news item to the return ArrayList.
                        returnList.Add(tempNewsItem);
                    }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnList;
        }
        public static string GetSubscriptionChannelName(string subscriptionUrl)
        {
            try
            {
                WebRequest myRequest = WebRequest.Create(subscriptionUrl);
                WebResponse myResponse = myRequest.GetResponse();
                Stream rssStream = myResponse.GetResponseStream();
                XmlDocument rssChannel = new XmlDocument();
                if (rssStream != null) rssChannel.Load(rssStream);
                XmlNode channelName = rssChannel.SelectSingleNode("rss/channel/title");
                if (channelName != null) return channelName.InnerText;
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return null;
        }
    }
}