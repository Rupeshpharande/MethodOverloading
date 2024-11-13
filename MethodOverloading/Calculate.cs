using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
   public class Calculate
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(double x,int y)
        {
            return x + y;
        }
        public double Add(int y, double x)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
        public double Sub(int x, double y)
        {
            return x - y;
        }
       
        public double Sub(double y,int x)
        {
            return y - x;
        }

        public int Mul(int x,int y) 
        {
                return x * y;
        }
       public double Mul(int x,double y)
        {
            return x * y;
        }

        public double Mul(double y,int x)
        {
            return y * x;
        }
        
    }
}
