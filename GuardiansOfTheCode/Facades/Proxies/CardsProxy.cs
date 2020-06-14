using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Common;
using Newtonsoft.Json;

namespace GuardiansOfTheCode.Facades.Proxies
{
    public class CardsProxy
    {
        private HttpClient _http;
        IEnumerable<Card> _cards;
        public CardsProxy()
        {
            _http = new HttpClient();
        }

        public async Task<IEnumerable<Card>> GetCards()
        {
            if (_cards == null)
                await FetchCards();
            return _cards;
        }

        private async Task FetchCards()
        {
            var cardsJson = await _http.GetStringAsync("http://localhost:5000/api/cards");
            _cards = JsonConvert.DeserializeObject<IEnumerable<Card>>(cardsJson);
        }

    }
}