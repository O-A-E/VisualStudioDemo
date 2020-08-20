using System;

namespace VisualStudioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name; 
            
            Console.WriteLine("Hello World! Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello World! Please enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Hello" + name); 
        }
    }
}
