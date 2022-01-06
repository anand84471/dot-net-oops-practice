using System;
using System.Collections.Generic;
using System.Text;

namespace OopsTestProjects.ClassTypes
{
    class PartialMethod
    {
    }
    partial class PartialMethodClass
    {
        partial void PartialMethod();
    }
    partial class PartialMethodClass
    {
        //partial classes can be created in same file also
        partial void PartialMethod()
        {
            throw new NotImplementedException();
        }
    }
}
