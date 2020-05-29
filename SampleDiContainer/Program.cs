using System;

namespace SampleDiContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new DIContainer();
            container.Register<IInterfaceA, ClassA>();
            container.Register<IInterfaceB, ClassB>();

            IInterfaceB b = container.Resolve<IInterfaceB>();
            b.doB();
        }
    }
}
