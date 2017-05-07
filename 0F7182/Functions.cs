using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _0F7182
{
    class Functions
    {
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public string logTime()
        {
            DateTime time = DateTime.Now;
            return time.ToString("MM/dd/yy h:mm:ss tt");
        }

        public string[] retrieveItemInfo(int itemID)
        {
            Regex regexPrice = new Regex("[<]div class=[\"]CurrentMarket[\">]+([0-9,]+)[<\\/]+");
            Regex regexName = new Regex("[<]div class=[\"]CurrentName[\">]+([a-zA-Z0-9 ()]+)[<\\/]+");
            string dataBase = "http://www.grandexchangecentral.com/item.php?rid=";
            string response = new WebClient().DownloadString(String.Format("{0}{1}", dataBase, itemID));

            List<string> itemInfo = new List<string>();

            Match matchPrice = regexPrice.Match(response);
            Match matchName = regexName.Match(response);

            if(matchPrice.Groups.Count > 1 && matchName.Groups.Count > 1)
            {
                itemInfo.Add(matchName.Groups[1].Value.ToString());
                itemInfo.Add(matchPrice.Groups[1].Value.ToString());
            }
            else
            {
                dataBase = "https://www.tip.it/runescape/items/view/";
                response = new WebClient().DownloadString(String.Format("{0}{1}", dataBase, itemID));
                regexPrice = new Regex("\\n\\n.*[<]td[>]([0 - 9,] +)[()0 - 9m.] + gp[<][\\/]td[>]\\n\\n");//[<]td[>]([0-9,]+)[ ()0-9m.]+gp[<][\\/]td[>]");
                regexName = new Regex("[<]h1[>](.*)[<][\\/]h1[>]");

                matchPrice = regexPrice.Match(response);
                matchName = regexName.Match(response);

                if(matchName.Groups.Count > 1)
                {
                    if(matchName.Groups[1].Value.ToString() != "Items Database")
                    {
                        itemInfo.Add(matchName.Groups[1].Value.ToString());
                    }
                    else
                    {
                        itemInfo.Add("Error".ToString());
                    }
                }
                else
                {
                    itemInfo.Add("Error".ToString());
                }

                if(matchPrice.Groups.Count > 1)
                {
                    itemInfo.Add(matchPrice.Groups[1].Value.ToString());
                }
                else
                {
                    itemInfo.Add("0");
                }

            }   
            return itemInfo.ToArray();
        }
    }
}
