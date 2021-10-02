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
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string choise = Console.ReadLine();

            switch (choise)
            {
                case "1": // Add book
                    AddBook(bookservice);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Do you want to continiue ? (y/n) : ");
                tyagain1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    string continiue1 = Console.ReadLine();
                    switch (continiue1.ToUpper())
                    {
                        case "Y":
                            Console.Clear();
                            goto tryagainmain;
                        case "N":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Shut Down ! ");
                            Console.WriteLine(DateTime.Now);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid Input ! ");
                            Console.Write("Pleace Try again : ");
                            goto tyagain1;

                    }
                    break;

                case "2": // Show All Books
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=======================================================================================================================");
                    Console.WriteLine("\t\t\t\t\t\t\t    Library  ") ;
                    Console.WriteLine("=======================================================================================================================");
                    Show(bookservice);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("==========================================================================");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Do you want to continiue ? (y/n) : ");
                tyagain2:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    string continiue2 = Console.ReadLine();
                    switch (continiue2.ToUpper())
                    {
                        case "Y":
                            Console.Clear();
                            goto tryagainmain;
                        case "N":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Shut Down ! ");
                            Console.WriteLine(DateTime.Now);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid Input ! ");
                            Console.Write("Pleace Try again : ");
                            goto tyagain2;

                    }
                    break;
                case "3": // Find Book By Name
                    FindBookByName(bookservice);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Do you want to continiue ? (y/n) : ");
                tyagain3:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    string continiue3 = Console.ReadLine();
                    switch (continiue3.ToUpper())
                    {
                        case "Y":
                            Console.Clear();
                            goto tryagainmain;
                        case "N":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Shut Down ! ");
                            Console.WriteLine(DateTime.Now);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid Input ! ");
                            Console.Write("Pleace Try again : ");
                            goto tyagain3;
                           
                    }
                    break;
                case "4": // Remove Book
                    RemoveBookByName(bookservice);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Do you want to continiue ? (y/n) : ");
                tyagain4:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    string continiue4 = Console.ReadLine();
                    switch (continiue4.ToUpper())
                    {
                        case "Y":
                            Console.Clear();
                            goto tryagainmain;
                        case "N":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Shut Down ! ");
                            Console.WriteLine(DateTime.Now);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid Input ! ");
                            Console.Write("Pleace Try again : ");
                            goto tyagain4;

                    }
                    break;
                case "5": // Search Book
                    SearchBook(bookservice);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Do you want to continiue ? (y/n) : ");
                tyagain5:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    string continiue5 = Console.ReadLine();
                    switch (continiue5.ToUpper())
                    {
                        case "Y":
                            Console.Clear();
                            goto tryagainmain;
                        case "N":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Shut Down ! ");
                            Console.WriteLine(DateTime.Now);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid Input ! ");
                            Console.Write("Pleace Try again : ");
                            goto tyagain5;

                    }
                    break;
                case "6": // search by page 
                    FindAllBooksByPageCountRange(bookservice);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Do you want to continiue ? (y/n) : ");
                tyagain6:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    string continiue6 = Console.ReadLine();
                    switch (continiue6.ToUpper())
                    {
                        case "Y":
                            Console.Clear();
                            goto tryagainmain;
                        case "N":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Shut Down ! ");
                            Console.WriteLine(DateTime.Now);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid Input ! ");
                            Console.Write("Pleace Try again : ");
                            goto tyagain6;

                    }
                    break;
                case "7": // Remove By No
                    RemoveByNo(bookservice);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Do you want to continiue ? (y/n) : ");
                tyagain7:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    string continiue7 = Console.ReadLine();
                    switch (continiue7.ToUpper())
                    {
                        case "Y":
                            Console.Clear();
                            goto tryagainmain;
                        case "N":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Shut Down ! ");
                            Console.WriteLine(DateTime.Now);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid Input ! ");
                            Console.Write("Pleace Try again : ");
                            goto tyagain7;

                    }
                    break;
                case "8": // Exit 
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Shut Down!");
                    Console.WriteLine(DateTime.Now);
                    return;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Choise not found !");
                    Console.WriteLine("Try again :");
                    goto tryagainmain;
                   
            }
        }
        public static void AddBook(IBookservice  bookservice)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Book Name : ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Author Name : ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string authorname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Page Count : ");

            tryagainpagecount:
            int pagecount;
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Book Added to Library");
            
            
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
            int count=0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter Name of Book : ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string name = Console.ReadLine();
            foreach (Book item in bookservice.books)
            {
                if (item.BookName.ToUpper().Contains(name.ToUpper()))
                {
                    count++;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Book Find !");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("===========================================================================================");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"Book Code : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{item.BookCode}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"Book : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{item.BookName}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"Author : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{item.BookAuthorName}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"Page Count : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{item.BookPageCount}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("===========================================================================================");
                    
                }
            }
            if (count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Book doesn't exist");
            }
        }
        public static void RemoveBookByName(IBookservice bookservice)
        {
            int count = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Book Name : ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string name = Console.ReadLine();

            foreach (var item in bookservice.books)
            {
                if (item.BookName.ToUpper().Contains(name.ToUpper()))
                {
                    count++;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    bookservice.books.Remove(item);
                    Console.WriteLine("Book Removed ! ");
                    break;
                }
            }
            if (count ==0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Book doesn't exsist ! ");
            }
        }
        public static void SearchBook(IBookservice bookservice)
        {
            int count= 0;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter String : ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string str = Console.ReadLine();

            foreach (Book item in bookservice.books)
            {
                if (item.BookName.ToUpper().Contains(str.ToUpper()))
                {
                    count++;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Book Finded By Name");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("==========================================================================================");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"Book Code : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{item.BookCode}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"Book : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{item.BookName}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"Author : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{item.BookAuthorName}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"Page Count : ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{item.BookPageCount}");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"==========================================================================================");
                }
                else
                {
                    if (item.BookAuthorName.ToUpper() == str.ToUpper())
                    {
                        count++;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Book Finded By Author Name");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("==========================================================================================");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"Book Code : ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"{item.BookCode}");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"Book : ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"{item.BookName}");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"Author : ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"{item.BookAuthorName}");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"Page Count : ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"{item.BookPageCount}");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($"==========================================================================================");

                    }
                    else
                    {
                        if (str == item.BookPageCount.ToString())
                        {
                            count++;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Book Finded By Page Count");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("==========================================================================================");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write($"Book Code : ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{item.BookCode}");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write($"Book : ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{item.BookName}");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write($"Author : ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{item.BookAuthorName}");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write($"Page Count : ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{item.BookPageCount}");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine($"==========================================================================================");
                        }
                        

                    }
                   
                }
            }
            if (count==0)
            {
              
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invaid Input");
                
            }
           
        }
        public static void FindAllBooksByPageCountRange(IBookservice bookservice)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Start Range : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        tryagainstartpagecount:
            int startpagecount;
            try
            {
                startpagecount = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Format is incorrect ! ");
                Console.WriteLine("Try Again :");
                goto tryagainstartpagecount;

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Max Range : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        tryagainmaxpagecount:
            int maxpagecount;
            try
            {
                maxpagecount = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
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
            int count = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter the Book No : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string bookno = Console.ReadLine();
            foreach (var item in bookservice.books)
            {
                if (item.BookCode == bookno.ToUpper())
                {
                    count++;
                    bookservice.books.Remove(item);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Book Removed !");
                    break;
                }
            }
            if (count==0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Book doesn't exist ! ");
            }
        }
    }
}

