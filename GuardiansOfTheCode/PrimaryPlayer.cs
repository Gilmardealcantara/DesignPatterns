using System;
using Common;
using GuardiansOfTheCode;
using GuardiansOfTheCode.Events;

namespace GuardiansOfTheCode
{
    public class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;
        private int _health;
        private event EventHandler<HealthChangedEventArgs> HealthChanged;
        private PrimaryPlayer() { }
        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer
            {
                Name = "Player-001",
                Level = 1,
                Armor = 25,
                Health = 100,
            };
        }
        public static PrimaryPlayer Instance { get { return _instance; } }
        public IWeapon Weapon { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        // public int Health { get; set; }
        public int Health
        {
            get
            {
                return _health;
            }
            private set
            {
                _health = value;
                HealthChanged?.Invoke(this, new HealthChangedEventArgs(Health));
            }
        }
        public int Armor { get; set; }
        public Card[] Cards { get; set; }

        public void Hit(int damage)
        {
            Health -= damage;
        }

        public void RegisterObserver(EventHandler<HealthChangedEventArgs> observer)
        {
            HealthChanged += observer;
        }
        public void UnRegisterObserver(EventHandler<HealthChangedEventArgs> observer)
        {
            HealthChanged -= observer;
        }

        public override string ToString()
        {
            return $"Player -> {Name}: (Health:{Health} Armor: {Armor})";
        }
    }
}