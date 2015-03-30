using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Quote_of_the_Day
{
    class Quote
    {
        const string BASE_SITE = "http://www.quotationspage.com";
        const string SITE = "http://www.quotationspage.com/random.php3";
        const string DATA_LINE = "<dt class=\"quote\">";

        const string SEPERATOR_1 = "href=\"";
        const string SEPERATOR_2 = "\">";
        const string SEPERATOR_3 = "</a>";

        string mQuote = null;
        string mAuthor = null;
        string mUrl = null;

        public Quote()
        {
            bool foundQuote = false;
            while (!foundQuote)
            {
                foundQuote = getData();
            }
        }

        public string getQuote()
        {
            return mQuote;
        }

        public string getAuthor()
        {
            return mAuthor;
        }

        public string getUrl()
        {
            return mUrl;
        }

        bool getData()
        {
            // Connection
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(SITE);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                string line;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                // Data
                while (true)
                {
                    try
                    {
                        line = readStream.ReadLine();
                    }
                    catch (Exception)
                    {
                        // End of html - no quote found
                        response.Close();
                        readStream.Close();
                        return false;
                    }
                    if (line.Contains(DATA_LINE))
                    {
                        // Jump to quote url
                        int i = line.IndexOf(SEPERATOR_1) + SEPERATOR_1.Length, j = line.IndexOf(SEPERATOR_2, i) + SEPERATOR_2.Length;
                        mUrl = BASE_SITE + line.Substring(i, j - i - SEPERATOR_2.Length);

                        // Jump to quote sentence
                        i = line.IndexOf(SEPERATOR_3, i);
                        mQuote = line.Substring(j, i - j);
                        mQuote = mQuote.Replace("<br>", "  ");

                        // Jump to quote author
                        i = line.LastIndexOf(SEPERATOR_1);
                        j = line.IndexOf(SEPERATOR_2, i) + SEPERATOR_2.Length;
                        i = line.IndexOf(SEPERATOR_3, j);

                        mAuthor = '-' + line.Substring(j, i - j);

                        // Bad parsing
                        if ((mAuthor.Contains('<'))||(mAuthor.Contains('>')))
                        {
                            mAuthor = string.Empty;
                        }
                    }

                    if ((mQuote != null) && (mAuthor != null))
                    {
                        break;
                    }
                }

                response.Close();
                readStream.Close();

                return true;
            }
            return false;
        }
    }
}
