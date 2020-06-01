namespace Common
{
    public abstract class CardDecorator : Card
    {
        protected Card _card;
        public CardDecorator(Card card, string name, int attack, int defense) : base(name, attack, defense)
        {
            _card = card;
        }

        public override string Name => $"{_card.Name}, {_name}";

        public override int Attack => _card.Attack + _attack;

        public override int Defense => _card.Defense + _defense;
    }
}