using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate c1=new Calculate();
            //Console.WriteLine("Addition");
            //Console.WriteLine(c1.Add(2, 4));
            //Console.WriteLine(c1.Add(3.12, 5));
            //Console.WriteLine(c1.Add(4,3.4));
            //Console.WriteLine("Substraction");
            //Console.WriteLine(c1.Sub(10.2, 2));
            //Console.WriteLine(c1.Sub(5, 1.1));
            //Console.WriteLine(c1.Sub(3.1, 1));
            //Console.WriteLine("Multiplication");
            //Console.WriteLine(c1.Mul(7.4, 2));
            //Console.WriteLine(c1.Mul(7, 8));
            //Console.WriteLine(c1.Mul(10,6.5));

            //OverloadAdd ol= new OverloadAdd();
            //Console.WriteLine(ol.Add(10.5, 5));
            //Console.WriteLine(ol.Add(15,10));
            //Console.WriteLine(ol.Add(5,10,15));

            //EmployeeConstOverload e = new EmployeeConstOverload();
            //EmployeeConstOverload e1 = new EmployeeConstOverload("Rupesh");
            //EmployeeConstOverload e2 = new EmployeeConstOverload(1, "Rohan");
            //Console.WriteLine(e.Print());
            //Console.WriteLine(e1.Print());
            //Console.WriteLine(e2.Print());


            Console.WriteLine(Payment.Paybill(4000));
            Console.WriteLine(Payment.Paybill(4000, "online"));
        }
    }
}
