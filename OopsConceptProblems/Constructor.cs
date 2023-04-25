using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptProblems
{
    public class ConstructorDemo:InterfaceTypes
    {
        public ClassName demo;
        //Constructor does not have a return type
        //Having same name as a class name
        //It automatically invokes if we didn't create when object is created
        public ConstructorDemo()
        {
            Console.WriteLine("It is default constructor");
        }
        public ConstructorDemo(string Company)
        {
            Console.WriteLine("It is single parameterized constructor");
        }

        public ConstructorDemo(string Name , int Id)
        {
            this.demo = demo;
            Console.WriteLine("It is parameterized constructor");
        }

        public void WithoutImplmentationMethod()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Hi there");
        }
    }
}
