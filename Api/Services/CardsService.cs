using System.Collections.Generic;
using Common;

namespace Api.Services
{
    public class CardsService : ICardsService
    {
        public IEnumerable<Card> FetchCards()
        {
            return new List<Card> {
                new Card ("Ultimate Shadow Wraith", 80, 90),
                new Card ("Puplet of Doom", 91, 64),
                new Card ("Lost Soul", 61, 77),
                new Card ("Plague Druid", 57, 55),
                new Card ("Rage Dragon", 95, 90),
            };
        }
    }
}