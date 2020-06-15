using Common;

namespace GuardiansOfTheCode.Commands
{
    public class CardEnemyBattleCommand : ICommand
    {
        private Card _card;
        private IEnemy _enemy;

        public CardEnemyBattleCommand(Card card, IEnemy enemy)
        {
            _card = card;
            _enemy = enemy;
        }

        public void Execute()
        {
            _enemy.Health -= _card.Attack;
        }
    }
}