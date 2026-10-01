using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ora09_28
{
    public class Gym
    {

        private string _name;

        public List<Membership> _memberships;

        public string Name { get { return _name; } set { _name = value; } }

        public List<Membership> Memberships { get { return _memberships; } set { _memberships = value; } }


        public Gym(string name)
        {
            _name = name;
            _memberships = new List<Membership>();
        }



        public int TotalIncome()
        {
            return _memberships.Sum(x => x.TotalCost());
        }


        public Member MostActive()
        {
            return _memberships.OrderByDescending(x => x.Owner.Visits).Select(x => x.Owner).First();
        }

        public Membership BestValue()
        {
            return _memberships.OrderBy(x => x.PricePerVisit()).Select(x => x).First();
        }
    }
}
