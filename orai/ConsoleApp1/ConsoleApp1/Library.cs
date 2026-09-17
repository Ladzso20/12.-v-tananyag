using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Library
    {
        public string Name { get; set; }

        private List<Book> _books {  get; set; }

        public int BookCount { get { return _books.Count; } }

        public Library(string name) 
        { 
            Name = name;

            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void PrintAll()
        {
            foreach (Book book in _books)
            {
                book.Describe();
            }
        }

        public string FindByTitle(string title)
        {
            return title;
        }
            
    }
}
