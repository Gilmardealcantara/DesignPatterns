using GuardiansOfTheCode;

namespace GuardiansOfTheCode
{
    public interface IEnemy
    {
        int Health { get; set; }
        int Level { get; }
        int OverTimeDamage { get; set; }
        int Armor { get; set; }
        bool Paralyzed { get; set; }
        int ParalyzedFor { get; set; }
        int Attack(PrimaryPlayer player);
        void Defend(PrimaryPlayer player);
    }
}