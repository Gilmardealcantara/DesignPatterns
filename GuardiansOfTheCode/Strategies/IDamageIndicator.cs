namespace GuardiansOfTheCode.Strategies
{
    public interface IDamageIndicator
    {
        void NotifyAboutDamage(int health, int damage);
    }
}