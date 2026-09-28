using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ora09_28
{
    public class Member
    {
        private string _name;

        private int _age;

        private bool _isStudent;

        private int _visits;



        public string Name { get { return _name; } set { _name = value; } }

        public int Age { get { return _age; } set { _age = value; } }

        public bool IsStudent { get { return _isStudent; } set { _isStudent = value; } }
        public int Visits { get { return _visits; } set { _visits = value; } }



        public Member(string name, int age, bool isStudent)
        {
            _name = name;
            _age = age;
            _isStudent = isStudent;
            _visits = 0;
        }

        public void Kiirat()
        {
            Console.WriteLine(Name + " " + Age + " " + IsStudent);
        }


        public void CheckIn()
        {
            _visits++;
        }

        public string Describe()
        {
            string i = "";
            if (IsStudent == false)
            {
               i = ($"{Name} ({Age} éves diák) - {Visits} látogatás.");
            }
            else
            {
                i = ($"{Name} ({Age} éves normál) - {Visits} látogatás.");
            }
            return i;
            
            
        }
    }
}
