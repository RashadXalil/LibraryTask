using minitask300920212.Interface;
using minitask300920212.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace minitask300920212.Service
{
    class IBookservice : Ibook
    {
        public List<Book> books = new List<Book>();
        public void ListoafBooks()
        {
            books.Add(new Book("Harry Potter", "J.K Rowling", 200));
            books.Add(new Book("Lord of The Rings ", "J.R.R Tolkien", 531));
            books.Add(new Book("Hobbit", "J.R.R Tolkien", 469));
            books.Add(new Book("Sherlock Holmes", "Arthur Conan Doyle", 213));
            books.Add(new Book("Arsene Lupin", "Maurice Leblanc", 669));
            books.Add(new Book("Les Misarable", "Victor Huqo", 831));
            books.Add(new Book("Anna Karenina ", "Lev Tolstoy", 1020));
        }
    }
}
