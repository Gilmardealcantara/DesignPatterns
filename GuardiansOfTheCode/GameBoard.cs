using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Common;
using Newtonsoft.Json;

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
        public async Task PlayArea(int lvl)
        {
            if (lvl == 1)
            {
                _player.Cards = (await this.FetchCards()).ToArray();
                Console.WriteLine("Ready to play Level 1 ?");
                Console.ReadKey();
                this.PlayFirstLevel();
            }
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

        private async Task<IEnumerable<Card>> FetchCards()
        {
            using (var client = new HttpClient())
            {
                var cardsJson = await client.GetStringAsync("http://localhost:5000/api/cards");
                var cards = JsonConvert.DeserializeObject<IEnumerable<Card>>(cardsJson);
                return cards;
            }
        }
    }
}