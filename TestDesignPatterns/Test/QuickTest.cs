using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    public interface ITestInterface1
    {
        void DoSomething();
    }

    class Class1 : ITestInterface1
    {
        public string x = string.Empty;

        public void DoSomething()
        {
            Console.WriteLine("Class1 is doing something.");
        }
    }

    class Class2 : ITestInterface1
    {
        public int y = 0;
        public int z = 0;

        public void DoSomething()
        {
            Console.WriteLine("Class2 is doing something.");
        }
    }

    
}
