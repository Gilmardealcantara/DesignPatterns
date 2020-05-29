using System;
using CSarp.DependecyInjection;
using CSarp.Singleton;

namespace CSarp
{
    class Program
    {
        static void TestDiContainer()
        {
            var container = new DIContainer();
            container.Register<IInterfaceA, ClassA>();
            container.Register<IInterfaceB, ClassB>();

            IInterfaceB b = container.Resolve<IInterfaceB>();
            b.doB();

        }

        static void Main(string[] args)
        {
            Program.TestDiContainer();

            // var s = PrimaryPlayer.Instance;
            // Console.WriteLine($"{s.Name} - lvl: {s.Level}");

            // var board = new GameBoard();
            // board.PlayArea(1);

        }
    }
}
