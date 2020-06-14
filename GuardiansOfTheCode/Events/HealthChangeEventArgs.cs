using System;

namespace GuardiansOfTheCode.Events
{
    public class HealthChangedEventArgs : EventArgs
    {
        public HealthChangedEventArgs(int health)
        {
            Health = health;
        }

        public int Health { get; private set; }
        public int Damage { get; private set; }
    }
}