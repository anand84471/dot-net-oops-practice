using System;
using System.Collections.Generic;
using System.Text;

namespace OopsTestProjects.Interfaces
{
    public interface InterfaceExample
    {
        public static string name;//static variables are allowed
        //public string newName; //instance fields are not allowed
        string newName { get; set; }
        //In that spirit, C# interfaces do allow properties to be defined - which the caller must supply an implementation for:
        string GetName();

    }
    public interface InterfaceExample1
    {
        public static string name;//static variables are allowed
        //public string newName; //instance fields are not allowed
        string newName { get; set; }
        //In that spirit, C# interfaces do allow properties to be defined - which the caller must supply an implementation for:
        string GetName();

    }
}
