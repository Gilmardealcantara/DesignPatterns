using System;

namespace MilkWayponLib
{
    public class Baster : ISpaceWeapon
    {
        private int _impactDamage;
        private int _lasertDamage;
        private int _missChange;

        public Baster(int impactDamage, int lasertDamage, int missChange)
        {
            _impactDamage = impactDamage;
            _lasertDamage = lasertDamage;
            _missChange = missChange;
        }

        public int ImpactDamage => _impactDamage;

        public int LasertDamage => _impactDamage;

        public int Shoot()
        {
            return _missChange;
        }
    }
}
