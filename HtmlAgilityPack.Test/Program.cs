using System;
using HtmlAgilityPack;

namespace HtmlAgilityPack.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string docurl   = "https://ebiz.khnp.co.kr/getTmpView.do?type=spbidnoti&loadId=fff84246-b957-47fc-a249-e1d023131890";
            var doc         = new HtmlWeb().Load(docurl).DocumentNode;
		    string aprice   = doc.SelectSingleNode("//th[text(),'가격점수제외금액(A)']").NextSibling.NextSibling.InnerText;

            Console.WriteLine(aprice);
            
        }
    }
}
