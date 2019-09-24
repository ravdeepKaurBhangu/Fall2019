using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethods
{
    class Program
    {
        static int add(int a,int b)
        {
            int c;
            c= a + b;
            return c;
        }
       static double subtract(double p,double q)
        {
            double e=p - q;
            return e;
        }

        static void multiply(int num1,int num2)
        {
            int m = num1 * num2;
            Console.WriteLine("Multiplication of two numbers is "+m);

        }
        static void display()
        {
            Console.WriteLine("Welcome to the world of programming");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome");
            int res=add(3,4);
            Console.WriteLine("Method has returned "+res);
            double s = subtract(5.6, 2.3);
            Console.WriteLine("Subtraction is "+s);
            multiply(4,6);
            display();
        }
    }
}
