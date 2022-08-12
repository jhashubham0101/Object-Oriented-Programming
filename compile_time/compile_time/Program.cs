// See https://aka.ms/new-console-template for more information
using System;
public class demo
{
    public static void Main(String[] args)
    {

       abc cal;

        add a = new add();
        cal = a;
        Console.WriteLine("Addition is" + cal.calculate(20, 20));

        sub s = new sub();
        cal = s;
        Console.WriteLine("Substraction is" + cal.calculate(20, 20));

        mul m = new mul();
        cal = m;
        Console.WriteLine("Multiplication is" + cal.calculate(20, 20));
        div d = new div();
        cal = d;
        Console.WriteLine("Division is" + cal.calculate(20, 20)); // referance

        Console.ReadLine();
    }
}
public abstract class abc
{
    public abstract int calculate(int a, int b);
}

public class add :abc
{
    public override int calculate(int a, int b)
    {
        return a + b;
    }
}

public class sub : abc
{
    public override int calculate(int a, int b)
    {
        return a - b;
    }
}

public class mul : abc
{
    public override int calculate(int a, int b)
    {
        return a * b;
    }
}

public class div : abc
{
    public override int calculate(int a, int b)
    {
        return a / b;
    }
}
