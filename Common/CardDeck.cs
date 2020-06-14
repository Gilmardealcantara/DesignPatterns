using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class CardDeck : ICardComponent
    {
        private List<ICardComponent> _componets = new List<ICardComponent>();
        public void Add(ICardComponent component) => _componets.Add(component);

        public ICardComponent Get(int index) => _componets[index];
        public bool Remove(ICardComponent component) => _componets.Remove(component);
        public string Display()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var component in _componets)
            {
                builder.Append(component.Display() + "\n\r");
            }
            return builder.ToString();
        }
    }
}