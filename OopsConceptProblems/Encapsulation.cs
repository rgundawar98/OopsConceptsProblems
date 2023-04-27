using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptProblems
{
    public class Encapsulation
    {
        //It will hide sensitive data from the user
        //Declare field or variable should be private
        //Property-get:Is read-only  and  Property-set:It is used to set data

        private string name = "Raj"; //Defined field is in private
        public string Name  //Property 
        {
            get
            {
                return name;
            }
            set
            {
                name = value; //name = value : It will set or assign value to the name
            }
        }
        public int RollNo
        {
            get; set;
        }
    }
}
