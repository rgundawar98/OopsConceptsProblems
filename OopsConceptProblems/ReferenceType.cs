using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptProblems
{
    // Rrference types are 
    public class ReferenceType
    {
        public void Reference_Type_Demo(ref int Num)
        {
            Num = Num * Num;
            Console.WriteLine(Num);
        }
    }
}
