using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptProblems
{
    //TypeCasting is used to assign a value one datatype to another datatype
    //By two ways we can do it
    //Implicit:It means automatically convert small type to large type
    //char=>int=>long=>float=>double
    //Explicit:Manually casting it is 
    //Reverse of the implicit convert large type to small type
    //double=>float=>long=>int=>char
    public class TypeCasting
    {
        public void Demo()
        {
           int value = 10;
           double ValueOne = value;
           int ValueTwo = 20;
           //long add = ValueOne + ValueTwo;  cannot convert from double to long
           Console.WriteLine(""+value+" "+ValueOne);
            double ValueThree = 20.6;
            int ValueFour = (int)ValueThree;//Explicit typecasting
            Console.WriteLine(ValueFour);
        }
    }
}
