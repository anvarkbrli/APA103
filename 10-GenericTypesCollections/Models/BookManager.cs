using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_GenericTypesCollections.Models
{
    internal class BookManager
    {
        public List<Book> Books { get; set; }
        public Dictionary<string, List<Book>> BooksByAuthor { get; set; }
        public Queue<string> WaitingQueue { get; set; }
        public Stack<Book> RecentlyReturned { get; set; }
        public BookManager()
        {
            Books = new List<Book>();
            BooksByAuthor = new Dictionary<string, List<Book>>();
            WaitingQueue = new Queue<string>();
            RecentlyReturned = new Stack<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);

            if (!BooksByAuthor.ContainsKey(book.Author))
            {
                BooksByAuthor[book.Author] = new List<Book>();
            }

            BooksByAuthor[book.Author].Add(book);
        }

        public string SearchByTitle(string title)
        {
            foreach (var book in Books)
            {
                if (title == book.Title)
                {
                    return title;
                }

            }
            return null;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            if (BooksByAuthor.ContainsKey(author))
            {
                return BooksByAuthor[author];
            }
            else
            {
                return new List<Book>();
            }

        }
        public void AddToWaitingQueue(string memberName)
        {
            WaitingQueue.Enqueue(memberName);
            Console.WriteLine($"[{memberName}] novbeye elave olundu");
        }
        public string ServeNextInQueue()
        {
            if(WaitingQueue.Count > 0)
            {
                return WaitingQueue.Dequeue();
            }
            else
            {
                return null;
            }
        }
        public void ReturnBook(Book book)
        {
            RecentlyReturned.Push(book);
            Console.WriteLine($"Kitab qebul edildi [{book.Title}]");
        }
        public string GetLastReturnedBook()
        {
            
            if(RecentlyReturned.Count > 0)
            { 
                string lastReturned = Convert.ToString(RecentlyReturned.Peek());
                return lastReturned;

            }
            else
            {
                return null;
            }
        }

    } 
}
