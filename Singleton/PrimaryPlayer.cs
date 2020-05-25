namespace CSarp.Singleton
{
    public class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;
        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer("Raptor", 1);
        }

        private PrimaryPlayer(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public static PrimaryPlayer Instance { get { return _instance; } }
        public string Name { get; set; }
        public int Level { get; set; }

    }
}