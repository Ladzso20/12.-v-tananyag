using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Librarian
    {
        public string Name { get; set; }

        private Library library { get; set; }

        public Librarian(string  name, Library library)
        {
            Name = name;

            this.library = library;
        }

        public (string,string) Introduce()
        {
            return (Name,library.Name);
        }
    }
}
