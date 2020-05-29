using System;

namespace CSarp.DependecyInjection
{
    public class ClassA : IInterfaceA
    {
        public void doA()
        {
            Console.WriteLine("Do A");
        }
    }
}