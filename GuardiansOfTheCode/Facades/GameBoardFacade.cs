using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GuardiansOfTheCode.Commands;
using GuardiansOfTheCode.Observer;
using GuardiansOfTheCode.Proxies;
using GuardiansOfTheCode.Strategies;

namespace GuardiansOfTheCode
{
    public class GameBoardFacade
    {
        private PrimaryPlayer _player;
        private int _areaLevel;
        private HttpClient _http;
        private List<IEnemy> _enemies = new List<IEnemy>();
        private CardsProxy _cardsProxy;

        public GameBoardFacade()
        {
            _cardsProxy = new CardsProxy();
        }
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
            this.StartTurns();
            // if (areaLevel == 1) this.PlayFirstLevel();
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
            var cards = await _cardsProxy.GetCards();
            _player.Cards = cards.ToArray();
        }

        private void LoadZombies(int areaLevel)
        {
            for (var i = 0; i < 10; i++)
                _enemies.Add(EnemyFactory.CreateZombie(areaLevel));
        }

        private void LoadWerewolves(int areaLevel)
        {
            for (var i = 0; i < 3; i++)
                _enemies.Add(EnemyFactory.CreateWerewolf(areaLevel));
        }
        private void LoadGiants(int areaLevel)
        {
            for (var i = 0; i < 10; i++)
                _enemies.Add(EnemyFactory.CreateGiant(areaLevel));
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

        private void StartTurns()
        {
            IEnemy currentEnemy = null;

            var regularObserver = new HealthChangedObserver(new RegularDamageIndicator());
            var criticalObserver = new HealthChangedObserver(new CriticalHealthIndicator());
            regularObserver.WatchPlayerHealth(_player);
            criticalObserver.WatchPlayerHealth(_player);

            while (true)
            {
                if (currentEnemy == null)
                {
                    if (_enemies.Count > 0)
                    {
                        currentEnemy = _enemies[0];
                        _enemies.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine("You won this level !");
                        break;
                    }
                }
                var commands = this.GetCommands(currentEnemy);
                foreach (var command in commands)
                {
                    command.Execute();
                    if (_player.Health <= 0 || currentEnemy.Health <= 0)
                    {
                        break;
                    }
                }
                // Thread.Sleep(500);
            }
        }

        private IEnumerable<ICommand> GetCommands(IEnemy enemy)
        {
            List<ICommand> commands = new List<ICommand>();
            commands.Add(new PlayerEnemyBattleCommand(_player, enemy));
            foreach (var card in _player.Cards)
            {
                commands.Add(new CardEnemyBattleCommand(card, enemy));
            }
            return commands;
        }
    }
}