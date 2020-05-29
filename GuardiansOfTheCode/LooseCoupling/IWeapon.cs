using CSarp.Factory;

namespace CSarp.LooseCoupling
{
    public interface IWeapon
    {
        int Damage { get; }
        void Use(IEnemy enemy);
    }
}