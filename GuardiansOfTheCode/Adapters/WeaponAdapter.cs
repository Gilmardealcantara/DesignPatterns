
using MilkWayponLib;

namespace GuardiansOfTheCode.Adapters
{
    public class WeaponAdapter : IWeapon
    {
        ISpaceWeapon _spaceWeapon;
        public WeaponAdapter(ISpaceWeapon spaceWeapon)
        {
            _spaceWeapon = spaceWeapon;
        }

        public int Damage => _spaceWeapon.LasertDamage + _spaceWeapon.ImpactDamage;

        public void Use(IEnemy enemy)
        {
            enemy.Health -= _spaceWeapon.Shoot();
        }
    }
}