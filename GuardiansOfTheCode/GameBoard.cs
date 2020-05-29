using System;
using System.Collections.Generic;

namespace GuardiansOfTheCode
{
    public class GameBoard
    {
        private PrimaryPlayer _player;
        public GameBoard()
        {
            _player = PrimaryPlayer.Instance;
            _player.Weapon = new Sword(12, 8);
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
            {
                Console.WriteLine("\nFlight:");
                Console.WriteLine(_player);
                Console.WriteLine(enemy);
                while (enemy.Health > 0 && _player.Health > 0)
                {
                    _player.Weapon.Use(enemy);
                    enemy.Attack(_player);
                }
                Console.WriteLine(_player);
                Console.WriteLine(enemy);
            }
        }
    }
}