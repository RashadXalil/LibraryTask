using minitask300920212.Models;
using minitask300920212.Service;
using System;
using System.Drawing;



namespace minitask300920212
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            IBookservice bookservice = new IBookservice();
            bookservice.ListoafBooks();

        tryagainmain:
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(@"                                       _      _ _                          
                                      | |    (_) |                         
                                      | |     _| |__  _ __ __ _ _ __ _   _ 
                                      | |    | | '_ \| '__/ _` | '__| | | |
                                      | |____| | |_) | | | (_| | |  | |_| |
                                      |______|_|_.__/|_|  \__,_|_|   \__, |
                                                                      __/ |
                                                                     |___/ ");
            Console.WriteLine("\n");
        
            Console.WriteLine("=========================================================================================== \n1.Add Book  \n2.Show All Books \n3.Find Book By Name \n4.Remove Book \n5.Search Book \n6.Search By Range of Page Counts \n7.Remove By No \n8.Exit \n===========================================================================================");
            Console.Write("Choise : ");

            string choise = Console.ReadLine();

            switch (choise)
            {
                case "1": // Add book
                    AddBook(bookservice);
                    goto tryagainmain;
                    
                case "2": // Show All Books
                    Console.Clear();
                    Console.WriteLine("=======================================================================================================================");
                    Console.WriteLine("\t\t\t\t\t\t\t    Library ") ;
                    Console.WriteLine("=======================================================================================================================");
                    Show(bookservice);
                    goto tryagainmain;
                case "3": // Find Book By Name
                    FindBookByName(bookservice);
                    goto tryagainmain;
                case "4": // Remove Book
                    RemoveBookByName(bookservice);
                    goto tryagainmain;
                case "5": // Search Book
                    SearchBook(bookservice);
                    goto tryagainmain;
                case "6": // search by page 
                    FindAllBooksByPageCountRange(bookservice);
                    goto tryagainmain;
                case "7": // Remove By No
                    RemoveByNo(bookservice);
                    goto tryagainmain;
                case "8": // Exit 
                    Console.WriteLine("Shut Down!");
                    Console.WriteLine(DateTime.Now);
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Choise not found !");
                    Console.WriteLine("Try again :");
                    goto tryagainmain;
                   
            }
        }
        public static void AddBook(IBookservice  bookservice)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Book Name : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Author Name : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string authorname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Page Count : ");

            tryagainpagecount:
            int pagecount;
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                pagecount = Convert.ToInt32(Console.ReadLine());
                if (pagecount <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Page Count 0'dan boyuk olmalidir !");
                    Console.Write("Yeniden cehd edin : ");
                    goto tryagainpagecount;

                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Daxil etdiyiniz melumatin formati yalnisdir !");
                Console.Write("Yeniden cehd edin : ");
                goto tryagainpagecount;
                
            }
            Book book = new Book(name, authorname, pagecount);
            bookservice.books.Add(book);
            Console.WriteLine(book.BookPageCount);
        }
        public static void Show(IBookservice bookservice)
        {
            
            foreach (var item in bookservice.books)
            {
                Console.WriteLine(item);
            }
        }
        public static void FindBookByName(IBookservice bookservice)
        {
            Console.Clear();
            Console.Write("Enter Name of Book : ");
            string name = Console.ReadLine();
            foreach (Book item in bookservice.books)
            {
                if (item.BookName.ToUpper().Contains(name.ToUpper()))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Book Find !");
                    Console.WriteLine("===========================================================================================");
                    Console.WriteLine($"Book Code : {item.BookCode} \nBook : {item.BookName} \nAuthor :{item.BookAuthorName} \nPage Count : {item.BookPageCount}");
                    Console.WriteLine("===========================================================================================");
                    
                }
            }
        }
        public static void RemoveBookByName(IBookservice bookservice)
        {
            Console.Clear();
            Console.Write("Book Name : ");
            string name = Console.ReadLine();

            foreach (var item in bookservice.books)
            {
                if (item.BookName.ToUpper().Contains(name.ToUpper()))
                {
                    bookservice.books.Remove(item);
                    Console.WriteLine("Book Removed ! ");
                    break;
                }
            }
        }
        public static void SearchBook(IBookservice bookservice)
        {
            
            Console.Write("Enter String : ");
            string str = Console.ReadLine();

            foreach (Book item in bookservice.books)
            {
                if (item.BookName.ToUpper().Contains(str.ToUpper()))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Book Finded By Name");
                    Console.WriteLine("==========================================================================================");
                    Console.WriteLine($"Book Code : {item.BookCode} Book : {item.BookName} Author : {item.BookAuthorName} Page Count : {item.BookPageCount}");
                    Console.WriteLine("==========================================================================================");
                }
                else
                {
                    if (item.BookAuthorName.ToUpper() == str.ToUpper())
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Book Finded by Author Name");
                        Console.WriteLine("==========================================================================================");
                        Console.WriteLine($"Book Code : {item.BookCode} Book : {item.BookName} Author : {item.BookAuthorName} Page Count : {item.BookPageCount}");
                        Console.WriteLine("==========================================================================================");

                    }
                    else
                    {
                        if (str == item.BookPageCount.ToString())
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Book Fined by Page Count ! ");
                            Console.WriteLine("==========================================================================================");
                            Console.WriteLine($"Book Code : {item.BookCode} Book : {item.BookName} Author : {item.BookAuthorName} Page Count : {item.BookPageCount}");
                            Console.WriteLine("==========================================================================================");
                        }

                    }
                   
                }
            }
           
        }
        public static void FindAllBooksByPageCountRange(IBookservice bookservice)
        {
            Console.Clear();
            Console.Write("Start Range : ");
        tryagainstartpagecount:
            int startpagecount;
            try
            {
                startpagecount = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format is incorrect ! ");
                Console.WriteLine("Try Again :");
                goto tryagainstartpagecount;

            }
            Console.Write("Max Range : ");
        tryagainmaxpagecount:
            int maxpagecount;
            try
            {
                maxpagecount = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.WriteLine("Format is incorrect !");
                Console.Write("Try Again :");
                goto tryagainmaxpagecount;

            }
            foreach (Book item in bookservice.books)
            {
                if (item.BookPageCount >= startpagecount && item.BookPageCount <= maxpagecount)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Book Finded ! ");
                    Console.WriteLine("==========================================================================================");
                    Console.WriteLine($"Book Code :{item.BookCode} \nBook : {item.BookName} \nAuthor : {item.BookAuthorName} \nPage Count : {item.BookPageCount}");
                    Console.WriteLine("==========================================================================================");
                }
            }
        }
        public static void RemoveByNo(IBookservice bookservice)
        {
            Console.Clear();
            Console.Write("Enter the Book No : ");
            string bookno = Console.ReadLine();
            foreach (var item in bookservice.books)
            {
                if (item.BookCode == bookno.ToUpper())
                {
                    bookservice.books.Remove(item);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Book Removed !");
                    break;
                }
            }
        }
    }
}
