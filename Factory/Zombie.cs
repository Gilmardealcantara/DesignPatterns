using System;
using CSarp.Singleton;

namespace CSarp.Factory
{
    public class Zombie : IEnemy
    {
        private int _health;
        private readonly int _level;

        public Zombie(int health, int level, int armor)
        {
            _health = health;
            _level = level;
            Armor = armor;
        }

        public int Health { get => _health; set => _health = value; }
        public int Level => _level;

        public int OverTimeDamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }

        public void Attack(PrimaryPlayer player)
        {
            Console.WriteLine($"Zombie attacking {player.Name}");
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine($"Zombie defending from {player.Name}");
        }

        public override string ToString()
        {
            return $"Enemy -> {this.GetType().Name}: (Health:{Health} Armor: {Armor})";
        }
    }
}