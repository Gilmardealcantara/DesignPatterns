using System;

namespace GuardiansOfTheCode.Strategies
{
    public class RegularDamageIndicator : IDamageIndicator
    {
        public void NotifyAboutDamage(int health, int damage)
        {
            if (health > 20)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Player took {damage} damage points. {health} HP remaining");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}