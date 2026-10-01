using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ora09_28
{
    public class Membership
    {
        private Member _owner;

        private int _monthlyPrice;

        private int _months;

        public Member Owner { get { return _owner; } set { _owner = value; } }

        public int MonthlyPrice { get { return _monthlyPrice; } set { _monthlyPrice = value; } }


        public int Months { get { return _months; } set { _months = value; } }




        public Membership(Member owner, int monthlyPrice, int months)
        {
            _owner = owner;

            _monthlyPrice = monthlyPrice;

            _months = months;
        }


        public int TotalCost()
        {
            int Cost = MonthlyPrice * Months;
            if (Owner.IsStudent == true)
            {
                return Convert.ToInt32(Cost * 0.8);
            }
            return Cost;
        }

        public void Extend(int months)
        {
            _months += months;
        }


        public int PricePerVisit()
        {
            if(Owner.Visits == 0)
            {
                return TotalCost();
            }
            return Convert.ToInt32((TotalCost() / Owner.Visits));
        }

    }
}
