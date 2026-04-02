using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_GenericTypesCollections.Models
{
    internal class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public Member(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            BorrowedBooks = new List<Book>();

        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count > 3)
            {
                Console.WriteLine("Maksimum 3 kitab goture bilersiniz");
                return;
            }
            else
            {
                BorrowedBooks.Add(book);
                Console.WriteLine($"Kitab goturuldu: [{book.Title}]");
            }
        }
        public void ReturnBook(int bookId)
        {
            Book foundBook = null;
            foreach (var book in BorrowedBooks)
            {
                
                if (book.Id == bookId)
                {
                    foundBook = book;
                    break;
                }
                
            }
            if (foundBook != null)
            {
                BorrowedBooks.Remove(foundBook);
                Console.WriteLine($"Kitab qaytarildi: [{foundBook.Title}]");
            }
            else
            {

                Console.WriteLine("Bu id - ye uygun kitab tapilmadi ");
            }
        }

        public void DisplayBorrowedBooks()
        {
            if(BorrowedBooks.Count == 0)
            {
                Console.WriteLine("Borc kitab yoxdur!");
                return;
            }
            else
            {
                foreach(var book in BorrowedBooks)
                {
                    Console.WriteLine(book.Title);
                }
            }
        }
    }
}
