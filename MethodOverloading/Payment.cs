using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Payment
    {
        public static String Paybill(double amount)
        {
            return $"you paid the bill of {amount} in cash.No Discount Applied";
        }

        public static String Paybill(double amount,string mode)
        {
            double disc = amount * 0.5;
            double bill = amount - disc;
            return $" if you paid the bill of {amount} by {mode} discount applied{disc} final bill is{bill}";
        }
    }
}
