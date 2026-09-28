using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MenuItem
    {
        public string Name { get; set; }

        public string Category { get; set; }

        private int _price;

        public static int Count { get; set; }

        public int Price 
        { 
            get 
            { 
                return _price; 
            }
            set
            {
                if (value < 0)
                {
                    _price = 0;
                    return;
                }
                _price = value;              
            }
        } 


        public bool IsAvalable { get; set; }
       
        public void SellOut()
        {
            IsAvalable = false;
            Console.WriteLine("nincs ilyen");
        }

        public void ReStock()
        {
            IsAvalable =true;
            Console.WriteLine("Van ilyen");
        }
        public MenuItem(string name, string category,int price)
        {
            Name = name;
            Category = category;
            Price = price;
            Count++;
        }
        public string GetDescriptrion()
        {
            return Name + " " + Category + " " + Convert.ToString(Price);
           
        }



    }
}
