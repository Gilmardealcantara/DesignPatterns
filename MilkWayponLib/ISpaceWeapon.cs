namespace MilkWayponLib
{
    public interface ISpaceWeapon
    {
        int ImpactDamage { get; }
        int LasertDamage { get; }
        int Shoot();
    }
}