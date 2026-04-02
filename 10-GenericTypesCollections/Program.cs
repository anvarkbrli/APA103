using _10_GenericTypesCollections.Models;
using System.Xml.Linq;
namespace _10_GenericTypesCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Book book1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
            Book book2 = new Book(2, "1984", "George Orwell", 1949, 328);
            Book book3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
            Book book4 = new Book(4, "Ag gemi", "Cingiz Aytmatov", 1970, 200);
            Book book5 = new Book(5, "Qırıq Budaq", "Elcin", 1998, 350);

            //book1.DisplayInfo();
            //book2.DisplayInfo();
            //book3.DisplayInfo();
            //book4.DisplayInfo();
            //book5.DisplayInfo();

            //2.
            //Library<Book> library = new Library<Book>("Milli Kitabxana");
            //library.Add(book1);
            //library.Add(book2);
            //library.Add(book3);
            //library.Add(book4);
            //library.Add(book5);
            //Console.WriteLine(library.Count());
            //Console.WriteLine(library.FindByIndex(0));
            //Console.WriteLine(library.FindByIndex(2));
            //Console.WriteLine("==================================");
            //var books = library.GetAll();
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}

            List<Member> members = new List<Member>()
            {
                new Member(1, "Ali Məmmədov", "ali@mail.com"),
                new Member(2, "Leyla Həsənova", "leyla@mail.com"),
                new Member(3, "Vüqar Əliyev", "vuqar@mail.com")
            };
            //Member member1 = members[0];
            //member1.BorrowBook(book1);
            //member1.BorrowBook(book2);
            //member1.DisplayBorrowedBooks();
            //member1.ReturnBook(1);
            //member1.DisplayBorrowedBooks();
            //member1.BorrowBook(book3);
            //member1.BorrowBook(book4);
            //member1.BorrowBook(book5);
            //member1.BorrowBook(book1);
            BookManager manager = new BookManager();

            //4.
            manager.AddBook(book1);
            manager.AddBook(book2);
            manager.AddBook(book3);
            manager.AddBook(book4);
            manager.AddBook(book5);

            //List<Book> orwellBooks = manager.GetBooksByAuthor("George Orwell");
            //foreach (var book in orwellBooks)
            //{
            //    Console.WriteLine(book);
            //}
            //Console.WriteLine($"Tapilan kitab sayi: {orwellBooks.Count}");

            //List<Book> aytmatovBooks = manager.GetBooksByAuthor("Cingiz Aytmatov");
            //foreach (var book in aytmatovBooks)
            //{
            //    Console.WriteLine(book);
            //}

            //Console.WriteLine($"Tapilan kitab sayi: {aytmatovBooks.Count}");
            //List<Book> londonBooks = manager.GetBooksByAuthor("Jack London");
            //foreach (var book in londonBooks)
            //{
            //    Console.WriteLine(book);
            //}
            //Console.WriteLine($"Tapilan kitab sayi: {londonBooks.Count}");

            //List<Book> dostoyevskiBooks = manager.GetBooksByAuthor("Dostoyevski");
            //foreach (var book in dostoyevskiBooks)
            //{
            //    Console.WriteLine(book);
            //}
            //Console.WriteLine($"Tapilan kitab sayi: {dostoyevskiBooks.Count}");

            //5.
            //manager.AddToWaitingQueue("Nigar");
            //manager.AddToWaitingQueue("Resad");
            //manager.AddToWaitingQueue("Sebine");
            //Console.WriteLine("Novbedeki insan sayi: " + manager.WaitingQueue.Count()); ;

            //string served1 = manager.ServeNextInQueue();
            //Console.WriteLine("Xidmet edilir: Nigar");
            //Console.WriteLine("Novbedeki insan sayi: " + manager.WaitingQueue.Count()); 

            //string served2 = manager.ServeNextInQueue();
            //Console.WriteLine("Xidmet edilir: Resad");
            //Console.WriteLine("Novbedeki insan sayi: " + manager.WaitingQueue.Count());


            //string served3 = manager.ServeNextInQueue();
            //Console.WriteLine("Xidmet edilir: Sebine");
            //Console.WriteLine("Novbedeki insan sayi: " + manager.WaitingQueue.Count()); 

            //6
            //manager.ReturnBook(book1);
            //manager.ReturnBook(book2);
            //manager.ReturnBook(book3);
            //Console.WriteLine("Stackdeki kitab sayi: " + manager.RecentlyReturned.Count());

            //Console.WriteLine(manager.GetLastReturnedBook());

            //manager.RecentlyReturned.Pop();
            //Console.WriteLine("Stackdeki kitab sayi: " + manager.RecentlyReturned.Count());

            //Console.WriteLine(manager.GetLastReturnedBook());

            //7.
            //manager.SearchByTitle("1984");
            //Console.WriteLine(manager.SearchByTitle("1984"));

            //string search1 = manager.SearchByTitle("Harry Potter");
            //if(search1 != null)
            //{
            //    Console.WriteLine("Harry Potter");
            //}
            //else
            //{
            //    Console.WriteLine("Bu adda kitab tapilmadi!(Null)");
            //}

            //8 - Statistika
            //Console.WriteLine(manager.Books.Count());
            //Console.WriteLine(members.Count());
            //Console.WriteLine(manager.WaitingQueue.Count());
            //Console.WriteLine(manager.RecentlyReturned.Count());

            //int minYear = manager.Books[0].Year;
            //int maxYear = manager.Books[0].Year;

            //foreach (var book in manager.Books)
            //{
            //    if (book.Year < minYear)
            //    {
            //        minYear = book.Year;
            //    }
            //    else if (book.Year > maxYear)
            //    {
            //        {
            //            maxYear = book.Year;
            //        }
            //    }

            //}
            //Console.WriteLine($"En kohne kitabin ili: {minYear}");
            //Console.WriteLine($"En yeni kitabin ili: {maxYear}");
        }
    }
}
