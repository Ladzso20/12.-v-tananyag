using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Menu
    {
        private List<MenuItem> _item;

        public string Name { get; set; }

        public Menu(string name, List<MenuItem> list)
        {
            Name = name;
            _item = list;
        }

        public void Additem(MenuItem item)
        {
            _item.Add(item);
        }
    }
}
