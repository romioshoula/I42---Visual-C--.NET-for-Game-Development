using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            //LibraryEngine libraryEngine = new LibraryEngine();
            Book book1 = new Book("ISBN1", "C# Book 1", new string[1] { "Rami" }, DateTime.Now, 100);
            Book book2 = new Book("ISBN2", "C# Book 2", new string[2] { "Rami", "Ahmed" }, DateTime.Now, 120);
            Book book3 = new Book("ISBN3", "C# Book 3", new string[3] { "Rami", "Ahmed", "Khaled" }, DateTime.Now, 300);

            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            Console.WriteLine("Delegates using fPtr implementation in C#:");
            Console.WriteLine("");

            Console.WriteLine("User Defined Delegate Datatype:");
            Console.WriteLine("Book Price:");
            AlphaDelegate fptr = new AlphaDelegate(BookFunctions.GetPrice);
            LibraryEngine.ProcessBooks(books, fptr);
            Console.WriteLine("");

            /**/
            Console.WriteLine("BCL Delegates:");
            Console.WriteLine("Book Price:");
            Func<Book, String> fptrBCL = new Func<Book, String>(BookFunctions.GetPrice);
            LibraryEngine.ProcessBooks(books, fptrBCL);
            Console.WriteLine("");

            Console.WriteLine("Anonymous Function Methods (GetISBN):");
            AlphaDelegate fptrAn = delegate (Book Alpha) { return Alpha.ISBN; };
            LibraryEngine.ProcessBooks(books, fptrAn);
            Console.WriteLine("");


            //
            Console.WriteLine("Lambda Expression (GetPublicationTitle):");
            AlphaDelegate fptrLambda = (Alpha) => Alpha.Title;
            LibraryEngine.ProcessBooks(books, fptrLambda); //DateTime.Now
            Console.WriteLine("");
            Console.WriteLine("Printing Date&Time:");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("");

            /**/
            Console.WriteLine("Authors:");
            Func<Book, String> fptrAuth = new Func<Book, String>(BookFunctions.GetAuthors);
            LibraryEngine.ProcessBooks(books, fptrAuth);
            Console.WriteLine("");

        }
    }
}