using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linq
{
    class book
    {
     public static void Main(String[] args)
        {
            IList<bdata> binfo = new List<bdata>()
          {
              new bdata(){ BookID=1001, BTitle="Believe in Yourself", BAuthor="Joseph Murphy", BPrice=1530},
              new bdata(){ BookID=1010, BTitle="Oneday life will change", BAuthor="Saranya Umakanthan", BPrice=1210},
              new bdata(){ BookID=1100, BTitle="The Power of Your Subconscious Mind", BAuthor="Joseph Murphy", BPrice=1780},
              new bdata(){ BookID=1101, BTitle="The Miracles of your mind", BAuthor="Joseph Murphy", BPrice=2530},
              new bdata(){ BookID=1110, BTitle="Harry Potter and the chamber of secrets", BAuthor="J.K.Rowling", BPrice=1930}
          };
            var bqry = from bdata in binfo
                       select bdata;
            foreach (var q in bqry)
                  Console.WriteLine("BookId:"+q.BookID+ "BookTitle:"+q.BTitle+ "AuthorName"+q.BAuthor+ "BookPrice:"+q.BPrice);
            Console.WriteLine("***************************************************************");

            var bkqry = from bkdata in binfo
                        where bkdata.BAuthor.Contains("Joseph Murphy")
                        select bkdata;
            foreach(var name in bkqry)
                 Console.WriteLine(name.BTitle);
            Console.WriteLine("***************************************************************");

            var qury = from books in binfo
                       orderby books.BPrice
                       select books;
            foreach (var names in qury)
                Console.WriteLine("BookPrice:" + names.BPrice + "BookName:" + names.BTitle);
            Console.WriteLine("***************************************************************");

            var aqry = from a in binfo
                        orderby a.BAuthor ascending
                        select a;
            foreach (var a in aqry)
                Console.WriteLine("AuhorName: "+a.BAuthor + "BookName:" + a.BTitle);

        }

        class  bdata
        {
            public  int BookID { get; set; }
            public string BTitle { get; set; }
            public string BAuthor { get; set; }
            public int BPrice { get; set; } 
        }
    }
}
