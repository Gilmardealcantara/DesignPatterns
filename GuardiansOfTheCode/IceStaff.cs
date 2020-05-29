using GuardiansOfTheCode;

namespace GuardiansOfTheCode
{
    public class IceStaff : IWeapon
    {
        private int _damage;
        private int _parelyzedFor;
        public int Damage { get => _damage; }

        public IceStaff(int damage, int parelyzedFor)
        {
            _damage = damage;
            _parelyzedFor = parelyzedFor;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= this.Damage;
            enemy.Paralyzed = true;
        }
    }
}