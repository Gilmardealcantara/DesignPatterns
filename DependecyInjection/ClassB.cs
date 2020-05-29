using System;

namespace CSarp.DependecyInjection
{
    public class ClassB : IInterfaceB
    {
        private IInterfaceA _classA;
        public ClassB(IInterfaceA classA)
        {
            _classA = classA;
        }

        public void doB()
        {
            _classA.doA();
            Console.WriteLine("Do B");
        }
    }
}