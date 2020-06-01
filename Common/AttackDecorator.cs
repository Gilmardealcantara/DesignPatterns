namespace Common
{
    public class AttackDecorator : CardDecorator
    {
        public AttackDecorator(Card card, string name, int attack) : base(card, name, attack, 0)
        {
        }
    }
}