using System;
using System.Collections.Generic;
using System.Text;

namespace OopsTestProjects.ClassTypes
{
    class PartialClass2
    {
    }
    partial class PartialClass
    {
        public string var1 { get; set; }
    }
    class PartialChild : PartialClass
    {
        public PartialChild()
        {
            var1 = "from first partial class";
            var2 = "from second partial class";
        }
    }
}
