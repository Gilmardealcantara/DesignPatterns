namespace CSarp.Factory
{
    public static class EnemyFactory
    {
        public static Zombie CreateZombie(int areaLevel)
        {
            if (areaLevel < 6)
                return new Zombie(50, 5);
            return new Zombie(100, 10);
        }
        public static Werewolf CreateWerewolf(int areaLevel)
        {
            if (areaLevel < 10)
                return new Werewolf(100, 15);
            return new Werewolf(100, 30);

        }
        public static Giant CreateGiant(int areaLevel)
        {
            if (areaLevel < 3)
                return new Giant(100, 15);
            else if (areaLevel >= 3 && areaLevel < 10)
                return new Giant(300, 50);
            return new Giant(600, 100);
        }
    }
}