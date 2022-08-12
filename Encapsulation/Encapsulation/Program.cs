using System;
namespace Encapsulation
{
    class Person
    {
        private string Name;
        private int Age;

        public void setName(string Name) // setter method
        {
            if (string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name is Must..");
            }
            else
            {
                this.Name = Name;
            }

        }

        public void setAge(int Age) // setter method
        {
            if (Age > 0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine("Age cannot be zero or negative");
            }

        }

        public void getAge() // getter method
        {
            if (Age > 0)
            {
                Console.WriteLine("Your age is: " + this.Age);
            }
            else
            {

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
           p.setName("Shubham");
           p.setAge(22);//if here put age = -22 then output is line number 30
           p.getAge();
            Console.ReadLine();
        }
    }
}