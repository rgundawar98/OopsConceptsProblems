﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptProblems
{
    public class ClassName:InterfaceTypes
    {
        //Non parameterized method
        public void Name()
        {
            Console.WriteLine("Rahul Gundawar");
        }

        //Parameterized method
        public void PrintType(string name)
        {
            Console.WriteLine(name);
        }

        public void WithoutImplmentationMethod()
        {
            Console.WriteLine("It is ClassName.cs");
        }
    }
}
