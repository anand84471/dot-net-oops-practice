using System;
using System.Collections.Generic;
using System.Text;

namespace OopsTestProjects.ClassTypes
{
    abstract class AbstractClass
    {
        public string Name { get; set; }
        private string Key { get; set; }
        protected string Id { get; set; }
        public abstract void AbsractMethod();
        public void PublicMethod()
        {

        }
    }
    abstract class AbstractClass2:AbstractClass
    {
        public new string Name { get; set; }
        public AbstractClass2()
        {
            this.Name = "Anand";
            this.Id = "123";
        }
        public override void AbsractMethod()
        {
            throw new NotImplementedException();
        }
        public abstract void ChildAbstractMethod();
    }
    class AbstractConcrete : AbstractClass2
    {
        public override void ChildAbstractMethod()
        {
            throw new NotImplementedException();
        }
    }

}
