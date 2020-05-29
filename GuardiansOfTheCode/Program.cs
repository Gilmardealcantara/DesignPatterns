using System;
using CSarp.Singleton;

namespace CSarp
{
    class Program
    {
        static void Main(string[] args)
        {

            // var s = PrimaryPlayer.Instance;
            // Console.WriteLine($"{s.Name} - lvl: {s.Level}");

            var board = new GameBoard();
            board.PlayArea(1);
        }
    }
}
