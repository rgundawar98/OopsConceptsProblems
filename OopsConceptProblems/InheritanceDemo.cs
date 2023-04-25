using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptProblems
{
    //Inheritance is totally depends upon child class and parent class
    //we used colon(:) to inherit one to another
    public class ParentClass : ChildClass
    {
        public ParentClass()
        {
            Console.WriteLine("This is my parent class");
        }
        public void Class()
        {
            Console.WriteLine("This is my method for parent class");
        }
    }
    public class ChildClass
    {
        public string name;
        public void TestMethod()
        {
            Console.WriteLine("It is Child Class");
        }
    }

}
