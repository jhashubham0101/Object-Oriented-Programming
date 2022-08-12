using System;
namespace Single_Inheratance
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
            b = 10;
    }
}
class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single level inheritance");
            B obj = new B();
            Console.WriteLine("a = {0}", obj.a);
            Console.WriteLine("b = {0}", obj.b);
        }
    }
   }