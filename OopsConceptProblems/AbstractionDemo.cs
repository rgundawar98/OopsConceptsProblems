using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptProblems
{
    //It will show the essential feature and hide complex data from user
    //It will achive withe help of abstract class and abstract methods
    public abstract class AbstractionDemo
    {
        //Use abstract keyword to create abstract method
        //We cannot cretae the object for the abstract class
        //Abstract and non abstract methods are present in abstract class
        public abstract void AbstractMethod();

        public void NonAbstractMethod()
        {
            Console.WriteLine("This is non-abstract method");
        }
    }
}
