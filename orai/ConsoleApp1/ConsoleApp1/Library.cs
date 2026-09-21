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

        public List<Book> FindByAuthor(string author)
        {
            List<Book> result = new List<Book>();
            foreach(Book book in _books)
            {
                if(book.Author == author)
                {
                    result.Add(book);
                }           
            }
            return result;
        }

        public int TotalPages()
        {
            return _books.Select(x => x.Pagecount).Sum();
        }


        public double AveragePages()
        {
            return _books.Average(x => x.Pagecount);
        }

        public List<Book> AvailableBooks()
        {
            List<Book > books = new List<Book>();
            foreach(Book book in _books)
            {
                if (_books.Contains(book))
                {
                    books.Add(book);
                }
            }
            return books;
        }
    }
}
