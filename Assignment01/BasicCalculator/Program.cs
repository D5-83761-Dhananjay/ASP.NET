using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1: add 2: sub 3: mul 4:div");
            int choice = Convert.ToInt32(Console.ReadLine());

            Calculator calculator = new Calculator();
            switch (choice)
            {
                case 1: Console.WriteLine("addition ="+calculator.add(num1, num2));
                    Console.ReadLine(); break;
                case 2: Console.WriteLine("subtraction =" + calculator.sub(num1, num2)); Console.ReadLine();  break;
                case 3: Console.WriteLine("multi ="+calculator.mul(num1, num2)); Console.ReadLine();  break;
                case 4: Console.WriteLine("division ="+calculator.div(num1, num2)); Console.ReadLine();  break;
            }
        }
        private class Calculator {
            public int add(int x, int y)
            {
                return x + y;
            }
            public int sub(int x, int y)
            {
                return x - y;
            }
            public int mul(int x, int y)
            {
                return x * y;
            }
            public int div(int x, int y)
            {
                return x / y;
            }

        }
    }
}
