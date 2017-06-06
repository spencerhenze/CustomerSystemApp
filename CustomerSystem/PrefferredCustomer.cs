using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSystem
{
    public class PrefferredCustomer : Customer //PrefferedCustomer objects inherit all of the properties from the subclasses "Customer" and "Person"
    {
        public PrefferredCustomer() //Constructor
        {

            _totalPurchases = 0;
            _discountLevel = -1;
        }

        //Fields
        public double _totalPurchases;
        public double _discountLevel;

        //Properties
        public double TotalPurchases
        {
            get { return _totalPurchases; }
            set { _totalPurchases = value; }
        }
        
        public double DiscountLevel
        {
            get { return _discountLevel; }
            set { _discountLevel = value; }
        }




        public double GetDiscountLevel(double totalPurchases)
        {
            if (totalPurchases >= 2000)
            {
                _discountLevel = .10;
            }
            else if (totalPurchases >= 1500)
            {
                _discountLevel = .07;
            }
            else if (totalPurchases >= 1000)
            {
                _discountLevel = .06;
            }
            else if (totalPurchases >= 500)
            {
                _discountLevel = .05;
            }
            else if (totalPurchases < 500)
            {
                _discountLevel = 0;
            }

            return _discountLevel;
        }
    }
}
