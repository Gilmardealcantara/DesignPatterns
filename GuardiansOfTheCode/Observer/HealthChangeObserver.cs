using GuardiansOfTheCode.Events;
using GuardiansOfTheCode.Strategies;

namespace GuardiansOfTheCode.Observer
{
    public class HealthChangedObserver
    {
        public IDamageIndicator _strategy;

        public HealthChangedObserver(IDamageIndicator strategy)
        {
            _strategy = strategy;
        }

        public void WatchPlayerHealth(PrimaryPlayer player)
        {
            player.RegisterObserver(Handler);
        }

        private void Handler(object sender, HealthChangedEventArgs args)
        {
            int damage = args.Damage;
            int health = args.Health;
            _strategy.NotifyAboutDamage(health, damage);
        }
    }
}