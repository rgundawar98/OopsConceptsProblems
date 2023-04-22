using System;

namespace OopsConceptProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Oops Concept Problems");
            ClassName name = new ClassName();
            name.Name();
            name.PrintType("Rajesh");
            ConstructorDemo constructorDemo = new ConstructorDemo();
           // ConstructorDemo demo = new ConstructorDemo("Rajesh");
            //ConstructorDemo democonstructor = new ConstructorDemo("Rohan", 121);
            //halt program execution until the user presses a key 
            //Console.ReadKey();
        }
    }
}
