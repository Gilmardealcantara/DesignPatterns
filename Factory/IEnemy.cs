using CSarp.Singleton;

namespace CSarp.Factory
{
    public interface IEnemy
    {
        int Health { get; set; }
        int Level { get; }
        void Attack(PrimaryPlayer player);
        void Defend(PrimaryPlayer player);
    }
}