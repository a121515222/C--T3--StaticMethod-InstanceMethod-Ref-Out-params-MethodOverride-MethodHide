using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSpace
{
    public class ClassA
    {
        public virtual void SampleOverrideMethod()
        {
            Console.WriteLine("ClassA Method");
        }
        public void SampleMethod() { 
            Console.WriteLine("ClassA Method"); 
        }
    }
    public class ClassB : ClassA
    {
        public override void SampleOverrideMethod()
        {
            Console.WriteLine("ClassB Method");
        }
    }
    public class ClassC: ClassA
    {
        public void SampleMethod()
        {
            Console.WriteLine("ClassC Method");
        }
    }
    public class Base1
    {
        public virtual void Print()
        {
            Console.WriteLine("Base Class");
        }
    }
    public class Sub1 : Base1
    {
        public override void Print()
        {
            Console.WriteLine("Sub Class");
        }
    }

}
