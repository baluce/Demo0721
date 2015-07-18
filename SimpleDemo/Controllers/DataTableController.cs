using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleDemo.Controllers
{
    public class DataTableController : Controller
    {
        public ActionResult Test0()
        {   
            return View();
        }

        public ActionResult GetData()
        {
            List<BrowserData> data = GetMyDataSource();

            //這裡要做匿名物件
            return Json(new { data = data }, JsonRequestBehavior.AllowGet);
        }

        private List<BrowserData> GetMyDataSource()
        {
            List<BrowserData> result = new List<BrowserData>();

            //將資料來源隔離出來,這裡可以改用其他資料來源,如DB,CSV,XML....
            foreach (var item in MyDataSource())
            {
                BrowserData data = new BrowserData();
                data.Engine = item[0];
                data.Browser = item[1];
                data.Platform = item[2];
                data.Version = item[3];
                data.Grade = item[4];
                result.Add(data);
            }
            return result;
        }

        private List<string[]> MyDataSource()
        {
            List<string[]> data = new List<string[]>();
            data.Add(new string[5] { "Trident", "Internet Explorer 4.0", "Win 95+", "4", "X" });
            data.Add(new string[5] { "Trident", "Internet Explorer 5.0", "Win 95+", "5", "C" });
            data.Add(new string[5] { "Trident", "Internet Explorer 5.5", "Win 95+", "5.5", "A" });
            data.Add(new string[5] { "Trident", "Internet Explorer 6", "Win 98+", "6", "A" });
            data.Add(new string[5] { "Trident", "Internet Explorer 7", "Win XP SP2+", "7", "A" });
            data.Add(new string[5] { "Trident", "AOL browser (AOL desktop)", "Win XP", "6", "A" });
            data.Add(new string[5] { "Gecko", "Firefox 1.0", "Win 98+ / OSX.2+", "1.7", "A" });
            data.Add(new string[5] { "Gecko", "Firefox 1.5", "Win 98+ / OSX.2+", "1.8", "A" });
            data.Add(new string[5] { "Gecko", "Firefox 2.0", "Win 98+ / OSX.2+", "1.8", "A" });
            data.Add(new string[5] { "Gecko", "Firefox 3.0", "Win 2k+ / OSX.3+", "1.9", "A" });
            data.Add(new string[5] { "Gecko", "Camino 1.0", "OSX.2+", "1.8", "A" });
            data.Add(new string[5] { "Gecko", "Camino 1.5", "OSX.3+", "1.8", "A" });
            data.Add(new string[5] { "Gecko", "Netscape 7.2", "Win 95+ / Mac OS 8.6-9.2", "1.7", "A" });
            data.Add(new string[5] { "Gecko", "Netscape Browser 8", "Win 98SE+", "1.7", "A" });
            data.Add(new string[5] { "Gecko", "Netscape Navigator 9", "Win 98+ / OSX.2+", "1.8", "A" });
            data.Add(new string[5] { "Gecko", "Mozilla 1.0", "Win 95+ / OSX.1+", "1", "A" });
            data.Add(new string[5] { "Gecko", "Mozilla 1.1", "Win 95+ / OSX.1+", "1.1", "A" });
            data.Add(new string[5] { "Gecko", "Mozilla 1.2", "Win 95+ / OSX.1+", "1.2", "A" });
            data.Add(new string[5] { "Gecko", "Mozilla 1.3", "Win 95+ / OSX.1+", "1.3", "A" });
            data.Add(new string[5] { "Gecko", "Mozilla 1.4", "Win 95+ / OSX.1+", "1.4", "A" });
            data.Add(new string[5] { "Gecko", "Mozilla 1.5", "Win 95+ / OSX.1+", "1.5", "A" });
            data.Add(new string[5] { "Gecko", "Mozilla 1.6", "Win 95+ / OSX.1+", "1.6", "A" });
            data.Add(new string[5] { "Gecko", "Mozilla 1.7", "Win 98+ / OSX.1+", "1.7", "A" });
            data.Add(new string[5] { "Gecko", "Mozilla 1.8", "Win 98+ / OSX.1+", "1.8", "A" });
            data.Add(new string[5] { "Gecko", "Seamonkey 1.1", "Win 98+ / OSX.2+", "1.8", "A" });
            data.Add(new string[5] { "Gecko", "Epiphany 2.20", "Gnome", "1.8", "A" });
            data.Add(new string[5] { "Webkit", "Safari 1.2", "OSX.3", "125.5", "A" });
            data.Add(new string[5] { "Webkit", "Safari 1.3", "OSX.3", "312.8", "A" });
            data.Add(new string[5] { "Webkit", "Safari 2.0", "OSX.4+", "419.3", "A" });
            data.Add(new string[5] { "Webkit", "Safari 3.0", "OSX.4+", "522.1", "A" });
            data.Add(new string[5] { "Webkit", "OmniWeb 5.5", "OSX.4+", "420", "A" });
            data.Add(new string[5] { "Webkit", "iPod Touch / iPhone", "iPod", "420.1", "A" });
            data.Add(new string[5] { "Webkit", "S60", "S60", "413", "A" });
            data.Add(new string[5] { "Presto", "Opera 7.0", "Win 95+ / OSX.1+", "-", "A" });
            data.Add(new string[5] { "Presto", "Opera 7.5", "Win 95+ / OSX.2+", "-", "A" });
            data.Add(new string[5] { "Presto", "Opera 8.0", "Win 95+ / OSX.2+", "-", "A" });
            data.Add(new string[5] { "Presto", "Opera 8.5", "Win 95+ / OSX.2+", "-", "A" });
            data.Add(new string[5] { "Presto", "Opera 9.0", "Win 95+ / OSX.3+", "-", "A" });
            data.Add(new string[5] { "Presto", "Opera 9.2", "Win 88+ / OSX.3+", "-", "A" });
            data.Add(new string[5] { "Presto", "Opera 9.5", "Win 88+ / OSX.3+", "-", "A" });
            data.Add(new string[5] { "Presto", "Opera for Wii", "Wii", "-", "A" });
            data.Add(new string[5] { "Presto", "Nokia N800", "N800", "-", "A" });
            data.Add(new string[5] { "Presto", "Nintendo DS browser", "Nintendo DS", "8.5", "C/A<sup>1</sup>" });
            data.Add(new string[5] { "KHTML", "Konqureror 3.1", "KDE 3.1", "3.1", "C" });
            data.Add(new string[5] { "KHTML", "Konqureror 3.3", "KDE 3.3", "3.3", "A" });
            data.Add(new string[5] { "KHTML", "Konqureror 3.5", "KDE 3.5", "3.5", "A" });
            data.Add(new string[5] { "Tasman", "Internet Explorer 4.5", "Mac OS 8-9", "-", "X" });
            data.Add(new string[5] { "Tasman", "Internet Explorer 5.1", "Mac OS 7.6-9", "1", "C" });
            data.Add(new string[5] { "Tasman", "Internet Explorer 5.2", "Mac OS 8-X", "1", "C" });
            data.Add(new string[5] { "Misc", "NetFront 3.1", "Embedded devices", "-", "C" });
            data.Add(new string[5] { "Misc", "NetFront 3.4", "Embedded devices", "-", "A" });
            data.Add(new string[5] { "Misc", "Dillo 0.8", "Embedded devices", "-", "X" });
            data.Add(new string[5] { "Misc", "Links", "Text only", "-", "X" });
            data.Add(new string[5] { "Misc", "Lynx", "Text only", "-", "X" });
            data.Add(new string[5] { "Misc", "IE Mobile", "Windows Mobile 6", "-", "C" });
            data.Add(new string[5] { "Misc", "PSP browser", "PSP", "-", "C" });
            data.Add(new string[5] { "Other browsers", "All others", "-", "-", "U" });
            return data;
        }
    }
}