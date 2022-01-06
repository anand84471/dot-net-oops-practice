using System;
using System.Collections.Generic;
using System.Text;

namespace OopsTestProjects.Interfaces
{
    public class MultipleInheritance : InterfaceExample1, InterfaceExample
    {
        public string newName { get; set; }

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
