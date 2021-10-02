using System;
using System.Collections.Generic;
using System.Text;

namespace minitask300920212.Models
{
    class Book
    {
        private static int _no = 10;
        public string BookCode;
        public string BookName;
        public string BookAuthorName;
        public int BookPageCount;
        public Book(string bookname, string authorname, int pagecount)
        {
            _no++;
            BookName = bookname;
            BookAuthorName = authorname;
            BookPageCount = pagecount;
            BookCode = bookname.Substring(0, 2).ToUpper() + _no;
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string allstr;
            string bookcode1;
            string bookcode2;
            string bookname1;
            string bookname2;
            string authorname1;
            string authorname2;
            string pagecount1;
            string pagecount2;
            
            bookcode1 =$"Book Code :";
            bookcode2 =$"{BookCode}";
            bookname1 =$"Book Name :";
            bookname2 =$"{BookName}";
            authorname1 =$"Author Name :";
            authorname2 =$"{BookAuthorName}";
            pagecount1 = $"Page Count :";
            pagecount2 = $"{BookPageCount}";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            allstr = $"{bookcode1} {bookcode2} \n{bookname1} {bookname2} \n{authorname1} {authorname2} \n{pagecount1} {pagecount2}";
            Console.WriteLine("==========================================================================");
            return allstr;

            //return $"------------------\nBook Code :{BookCode} \n------------------\nBook Name : {BookName} \n------------------\nAuthor : {BookAuthorName} \n------------------\nBook Page : {BookPageCount} \n\n=========================\n";
        }
        public void AddBook(string bookname, string authorname, int pagecount)
        {
            _no++;
            BookName = bookname;
            BookAuthorName = authorname;
            BookPageCount = pagecount;
            BookCode = bookname.Substring(0, 2).ToUpper() + _no;
        }
       

    }
}
