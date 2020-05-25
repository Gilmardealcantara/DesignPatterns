using System;
using CSarp.Singleton;

namespace CSarp.Factory
{
    public class Giant : IEnemy
    {
        private int _health;
        private readonly int _level;

        public Giant(int health, int level)
        {
            _health = health;
            _level = level;
        }

        public int Health { get => _health; set => _health = value; }
        public int Level => _level;

        public void Attack(PrimaryPlayer player)
        {
            Console.WriteLine($"Giant attacking {player.Name}");
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine($"Giant defending from {player.Name}");
        }
    }
}