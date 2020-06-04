using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Common;
using Newtonsoft.Json;

namespace GuardiansOfTheCode
{
    public class GameBoardFacade
    {
        private PrimaryPlayer _player;
        private int _areaLevel;
        private HttpClient _http;
        private List<IEnemy> _enemies = new List<IEnemy>();

        public async Task Play(PrimaryPlayer player, int areaLevel)
        {
            _player = player;
            _areaLevel = areaLevel;
            ConfigurePlayerWeapon();
            await AddPlayerCards();
            LoadZombies(areaLevel);
            LoadWerewolves(areaLevel);
            LoadGiants(areaLevel);
            // Begin Playing Logic

            if (areaLevel == 1) this.PlayFirstLevel();
        }

        private void ConfigurePlayerWeapon()
        {
            string input;
            int choice;
            while (true)
            {
                Console.WriteLine("Pick a weapon ?");
                Console.WriteLine("1. Sword");
                Console.WriteLine("2. Fire Staff");
                Console.WriteLine("3. Ice Staff");
                input = Console.ReadLine();
                if (int.TryParse(input, out choice))
                {
                    if (choice == 1)
                    {
                        _player.Weapon = new Sword(15, 7);
                        break;
                    }
                    else if (choice == 2)
                    {
                        _player.Weapon = new FireStaff(12, 14);
                        break;
                    }
                    else if (choice == 3)
                    {
                        _player.Weapon = new IceStaff(5, 1);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Inválid input");
                }

            }
        }

        private async Task AddPlayerCards()
        {
            using (_http = new HttpClient())
            {
                var cardsJson = await _http.GetStringAsync("http://localhost:5000/api/cards");
                var cards = JsonConvert.DeserializeObject<IEnumerable<Card>>(cardsJson);
                _player.Cards = cards.ToArray();
            }
        }

        private void LoadZombies(int areaLelvel)
        {
            for (var i = 0; i < 10; i++)
                _enemies.Add(EnemyFactory.CreateZombie(areaLelvel));
        }

        private void LoadWerewolves(int areaLelvel)
        {
            for (var i = 0; i < 3; i++)
                _enemies.Add(EnemyFactory.CreateWerewolf(areaLelvel));
        }
        private void LoadGiants(int areaLelvel)
        {
            for (var i = 0; i < 10; i++)
                _enemies.Add(EnemyFactory.CreateGiant(areaLelvel));
        }

        private void PlayFirstLevel()
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