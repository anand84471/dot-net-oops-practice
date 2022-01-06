using System;
using System.Collections.Generic;
using System.Text;

namespace OopsTestProjects.Constants
{
    public class FinalConstants
    {
        public const string name= "Anand";
        //public const int age; // compile time error bcoz value should be set at the time of declaration only
        public static void Main(string[] args)
        {
            Console.WriteLine(FinalConstants.name);
        }
    }
}
