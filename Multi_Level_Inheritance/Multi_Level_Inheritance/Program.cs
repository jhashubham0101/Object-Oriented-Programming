using System;
namespace Multi_Level_Inheritance
{
    class A
    {
        public int a;
        public A()
        {
            a = 8;
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
    class C : B
    {
        public int c;
        public C()
        {
            c = 25;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi Level inheritance");
            C obj = new C();
            Console.WriteLine("a = {0}", obj.a);
            Console.WriteLine("b = {0}", obj.b);
            Console.WriteLine("c = {0}", obj.c);
        }
    }
}