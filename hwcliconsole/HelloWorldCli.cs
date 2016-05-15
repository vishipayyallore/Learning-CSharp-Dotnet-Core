using System;

namespace ConsoleApplication
{
    public class HelloWorldCli
    {
        public static void Main(string[] args)
        {
            var user = new Person { Name = "Shiva Sai", Age = 26 };
            
            Console.WriteLine("User Details ....");
            Console.WriteLine($"Name: {user.Name}\nAge: {user.Age}");
            
            Console.ReadLine();
        }
    }
}
