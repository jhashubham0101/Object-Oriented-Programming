using System;

namespace Inheritance
{
    class Animal
    {

        public string? name;

        public void display()
        {
            Console.WriteLine("animal");
        }

    }
    class Dog : Animal
    {

        public void getName()
        {
            Console.WriteLine("" + name);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Dog labrador = new Dog();
            labrador.name = "puppy";
            labrador.display();
            labrador.getName();

            Console.ReadLine();
        }

    }
}