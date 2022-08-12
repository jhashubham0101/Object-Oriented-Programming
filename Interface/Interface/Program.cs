using System;
namespace Interface
{
    class Program
    {
        static void Main()
        {
            ImplementationClass1 obj1 = new ImplementationClass1();
            obj1.Add(100, 200);

            ImplementationClass2 obj2 = new ImplementationClass2();
            obj2.Add(10, 20);
            obj2.Sub(100, 20);

            Console.ReadKey();
        }
    }

    interface Interface1
    {
        void Add(int num1, int num2);
    }
    interface Interface2 : Interface1
    {
        void Sub(int num1, int num2);
    }

    public class ImplementationClass1 : Interface1
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is:{num1 + num2}");
        }
    }

    public class ImplementationClass2 : Interface2
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is:{num1 + num2}");
        }

        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Divison of {num1} and {num2} is:{num1 - num2}");
        }
    }
}