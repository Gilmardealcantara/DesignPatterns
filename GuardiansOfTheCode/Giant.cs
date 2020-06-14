using System;
using GuardiansOfTheCode;

namespace GuardiansOfTheCode
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

        public int OverTimeDamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }

        public int Attack(PrimaryPlayer player)
        {
            Console.WriteLine($"Giant attacking {player.Name}");
            return 30;
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine($"Giant defending from {player.Name}");
        }

        public override string ToString()
        {
            return $"Enemy -> {this.GetType().Name}: (Health:{Health} Armor: {Armor})";
        }
    }
}