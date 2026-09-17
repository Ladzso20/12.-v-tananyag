using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {

        private int _pageCount;
        public string Title { get; set; }

        public string Author { get; set; }
        
        static int Count { get; set; } = 0;

        public bool IsAvailable { get; set; }

        public int Pagecount
        {
            get { return _pageCount; }
            set
            {
                if (value < 0)
                {
                    _pageCount = 0;
                }
                else
                {
                    _pageCount = value;
                }
            }
        }
 


        public Book(string title, string author, int pagecount)
        {
            Title = title;
            Author = author;
            Pagecount = pagecount;
            Count++;
        }


        public void Describe()
        {
            Console.WriteLine(Title + " " + Author + " " + _pageCount + " " + Count);
        }



        public bool IsLong()
        {
            if(Pagecount > 300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Pagecount = 0;
            Count++;
        }

        public void Describe2()
        {
            Console.WriteLine(Title + " " + Author + " " + _pageCount + " " +  Count );
        }

        public bool Borrow()
        {
            if (IsAvailable == true)
            {
                IsAvailable = false;
                return true;
            }
            return false;
        }

        public void Return()
        {
            IsAvailable = true;         
        }

    }



}
