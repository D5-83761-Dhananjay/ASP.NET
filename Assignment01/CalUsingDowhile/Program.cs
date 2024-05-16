using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalUsingDowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Calculator calculator = new Calculator();
            calculator.menu();
        }

        private class Calculator
        {
            private int choice;
            public void add()
            {
                Console.WriteLine("enter x ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter y");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int a = num1 + num2;
                Console.WriteLine(a);

            }
            public void sub()
            {
                Console.WriteLine("enter x ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter y");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int a = num1 - num2;
                Console.WriteLine(a);
            }
            public void mul()
            {
                Console.WriteLine("enter x ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter y");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int a = num1 * num2;
                Console.WriteLine(a);
            }
            public void div()
            {
                Console.WriteLine("enter x ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter y");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int a = num1 / num2;
                Console.WriteLine(a);
            }

            public void menu()
            {
                do
                {
                    Console.WriteLine("0: exit 1: add 2: sub 3: mul 4:div");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        add();
                    }
                    else if(choice == 2)
                    {
                        sub();
                    }
                    else if (choice == 3)
                    {
                        mul();
                    }
                    else if (choice == 4)
                    {
                        div();
                    }
                    else
                    {
                        Console.WriteLine("enter valid choice");
                        Console.ReadLine();
                    }
                } while (choice!=0);
            }

        }

    }
}
