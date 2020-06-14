using System;

namespace GuardiansOfTheCode.Strategies
{
    public class CriticalHealthIndicator : IDamageIndicator
    {
        public void NotifyAboutDamage(int health, int damage)
        {
            if (health <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"HEALTH CRITICAL! {damage} points taken, {health} HP remaining");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}