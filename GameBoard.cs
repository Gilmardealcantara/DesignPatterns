using System;
using System.Collections.Generic;
using CSarp.Factory;
using CSarp.Singleton;

namespace CSarp
{
    public class GameBoard
    {
        private PrimaryPlayer _player;
        public GameBoard()
        {
            _player = PrimaryPlayer.Instance;
        }
        public void PlayArea(int lvl)
        {
            if (lvl == 1)
                this.PlayFirstLevel();
        }

        public void PlayFirstLevel()
        {
            int currentLvl = 1;
            var enemies = new List<IEnemy>();
            for (var i = 0; i < 10; i++)
                enemies.Add(EnemyFactory.CreateZombie(currentLvl));

            for (var i = 0; i < 3; i++)
                enemies.Add(EnemyFactory.CreateWerewolf(currentLvl));

            foreach (var enemy in enemies)
                Console.WriteLine(enemy.GetType());

        }
    }
}