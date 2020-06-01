using Common;
using GuardiansOfTheCode;

namespace GuardiansOfTheCode
{
    public class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;
        private PrimaryPlayer(string name, int level)
        {
            Name = name;
            Level = level;
        }
        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer("Player-001", 1)
            {
                Armor = 25,
                Health = 100,
            };
        }
        public static PrimaryPlayer Instance { get { return _instance; } }
        public IWeapon Weapon { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public Card[] Cards { get; set; }

        public override string ToString()
        {
            return $"Player -> {Name}: (Health:{Health} Armor: {Armor})";
        }
    }
}