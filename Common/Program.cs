using System;

namespace Common
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestDecoratorPattern();
            TestCompositePattern();
        }

        private static void TestCompositePattern()
        {
            CardDeck deck = new CardDeck();
            CardDeck attackDeck = new CardDeck();
            CardDeck defenseDeck = new CardDeck();

            attackDeck.Add(new Card("Basic Infantry Unit", 12, 15));
            attackDeck.Add(new Card("Advanced Infantry Unit", 25, 18));
            attackDeck.Add(new Card("Cavalry Unit", 32, 24));

            defenseDeck.Add(new Card("Woolden Shield", 0, 6));
            defenseDeck.Add(new Card("Iron Shield", 0, 9));
            defenseDeck.Add(new Card("Shining Royal Armor", 0, 40));


            deck.Add(attackDeck);
            deck.Add(new Card("Small Beast", 16, 13));
            deck.Add(new Card("Hight Elf Rogue", 22, 7));
            deck.Add(defenseDeck);

            Console.WriteLine(deck.Display());
        }

        private static void TestDecoratorPattern()
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
