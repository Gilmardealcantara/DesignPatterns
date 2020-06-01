namespace Common
{
    public class DefenceDecorator : CardDecorator
    {
        public DefenceDecorator(Card card, string name, int defense) : base(card, name, 0, defense)
        {
        }
    }
}