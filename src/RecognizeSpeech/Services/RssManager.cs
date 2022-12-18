using System;
using System.Xml.XPath;

namespace RecognizeSpeech.Services;

public class RssManager
{
    string rssURL = "http://feeds.bbci.co.uk/news/technology/rss.xml";
    string rssSelect = "paditembox";

    public RssManager()
	{
        

    }

    public void GetFeed()
    {
        try
        {

            // Bring back the Feed
            XPathDocument doc = new XPathDocument(rssURL);
            XPathNavigator nav = doc.CreateNavigator();
            XPathNodeIterator iter = nav.Select(rssSelect);
            // Loop through the nodes
            while (iter.MoveNext())
            {
                // Get the data we need from the node
                ProcessNode(iter.Current);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
    }

    void ProcessNode(XPathNavigator lstNav)
    {
        string title = "";
        string link = "";
        string description = "";
        // Get the child nodes
        XPathNodeIterator iterNews = lstNav.SelectDescendants(XPathNodeType.Element, false);
        // Loop through the child nodes
        while (iterNews.MoveNext())
        {
            // Save the current Name
            string rssName = iterNews.Current.Name;
            // Is this the title?
            //if (rssName.ToUpper() == rssTitle.ToUpper())
            //{ title = iterNews.Current.Value; }
            //// Is this the Link?
            //if (rssName.ToUpper() == rssLink.ToUpper())
            //{ link = iterNews.Current.Value; }
            //// Is this the Description?
            //if (rssName.ToUpper() == rssDescription.ToUpper())
            //{ description = iterNews.Current.Value; }
        }
        // Make sure the link and title are at least 10 characters long
        if (link.Length > 10 && title.Length > 10)
        {
           
        }
    }
}

