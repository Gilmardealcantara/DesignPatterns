using System;

namespace Common
{
    class Program
    {
        static void Main(string[] args)
        {
            Card soldier = new Card("soldier", 25, 20);
            Console.WriteLine($"{soldier.Name} => {soldier.Attack}/{soldier.Defense}");
            soldier = new AttackDecorator(soldier, "Sword", 15);
            Console.WriteLine($"{soldier.Name} => {soldier.Attack}/{soldier.Defense}");
            soldier = new AttackDecorator(soldier, "Amulet", 5);
            Console.WriteLine($"{soldier.Name} => {soldier.Attack}/{soldier.Defense}");
            soldier = new DefenceDecorator(soldier, "Helmet", 10);
            Console.WriteLine($"{soldier.Name} => {soldier.Attack}/{soldier.Defense}");
            soldier = new DefenceDecorator(soldier, "Heavy Armor", 45);
            Console.WriteLine($"{soldier.Name} => {soldier.Attack}/{soldier.Defense}");
        }
    }
}
