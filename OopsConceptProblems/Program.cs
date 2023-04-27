using System;

namespace OopsConceptProblems
{
    internal class Program:AbstractionDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Oops Concept Problems");
            ClassName name = new ClassName();
            name.Name();
            name.PrintType("Rajesh");
            ConstructorDemo constructorDemo = new ConstructorDemo();
            name.WithoutImplmentationMethod();
            ConstructorDemo parameter = new ConstructorDemo();
            parameter.WithoutImplmentationMethod();
            //This is enum related
            Console.WriteLine(Data.Shreya);
            Console.WriteLine(Data.Rohit);
            //By using var we can display value of enum element
            int count = (int)Data.Shreya;
            Console.WriteLine(count);
            //ConstructorDemo democonstructor = new ConstructorDemo("Rohan", 121);
            //halt program execution until the user presses a key 
            //Console.ReadKey();
            //This is for Inheritance
            ParentClass parent = new ParentClass();
            Console.WriteLine(parent.name = "Rajesh");
            parent.TestMethod();
            parent.Class();
            Program prog = new Program();
            prog.NonAbstractMethod();
            prog.AbstractMethod(); 
            //TypeCasting
            TypeCasting typeCasting = new TypeCasting();
            typeCasting.Demo();
        }

        //It will Override keyword the base class method in derived class 
        public override void AbstractMethod()
        {
            Console.WriteLine("This is override/implemented abstract class");
        }
    }
}
