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
            return $"------------------\nBook Code : {BookCode} \n------------------\nBook Name : {BookName} \n------------------\nAuthor : {BookAuthorName} \n------------------\nBook Page : {BookPageCount} \n\n=========================\n";
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
