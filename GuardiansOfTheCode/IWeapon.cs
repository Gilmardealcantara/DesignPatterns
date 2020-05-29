using GuardiansOfTheCode;

namespace GuardiansOfTheCode
{
    public interface IWeapon
    {
        int Damage { get; }
        void Use(IEnemy enemy);
    }
}