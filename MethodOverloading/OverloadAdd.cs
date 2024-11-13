using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class OverloadAdd
    {
        //method to add two integer
       public int Add(int a,int b)
        {
            return a + b;
        }

        //method to add three integer
        public int Add(int a,int b,int c) 
        {
               return a+b+c;
        }
        public double Add(double a, int b)
        {
            return a + b;
        }

    }
}
