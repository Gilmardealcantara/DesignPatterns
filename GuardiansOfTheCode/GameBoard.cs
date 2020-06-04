using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Common;
using Newtonsoft.Json;
using MilkWayponLib;
using GuardiansOfTheCode.Adapters;

namespace GuardiansOfTheCode
{
    public class GameBoard
    {
        private PrimaryPlayer _player;
        private GameBoardFacade _gameBoardFacade;
        public GameBoard()
        {
            _player = PrimaryPlayer.Instance;
            _gameBoardFacade = new GameBoardFacade();
        }
        public async Task PlayArea(int lvl)
        {
            if (lvl == -1)
            {
                Console.WriteLine("Ready to play special Level ?");
                Console.ReadKey();
                this.PlaySpecialLevel();
            }
            else
            {
                await _gameBoardFacade.Play(_player, lvl);
            }
        }

        private void PlaySpecialLevel()
        {
            _player.Weapon = new WeaponAdapter(new Baster(20, 15, 15));
        }
    }
}