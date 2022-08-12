using System;
namespace Hierarchical_Inheritance
{
    class A
    {
        public int a;
        public A()
        {
            a = 50;
        }
    }
    class B : A
    {
        public int b;
        public B()
        {
            b = 20;
        }
    }
    class C : A
    {
        public int c;
        public C()
        {
            c = 30;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hierarchical inheritance");
            B obj1 = new B();
            C obj2 = new C();
            Console.WriteLine("Using class B object (obj1)");
            Console.WriteLine("a = {0}", obj1.a);
            Console.WriteLine("b = {0}", obj1.b);
            Console.WriteLine("Using class C object (obj2)");
            Console.WriteLine("a = {0}", obj2.a);
            Console.WriteLine("c = {0}", obj2.c);
        }
    }
}