namespace GuardiansOfTheCode.Multiplayer
{
    public class PaidState : IState
    {
        private SubscriptionManager _manager;

        public PaidState(SubscriptionManager manager)
        {
            _manager = manager;
        }

        public void Expire()
        {
            throw new System.InvalidOperationException("Cannot expire an paid membership");
        }

        public void Pay()
        {
            throw new System.InvalidOperationException("Cannot pay an already paid service");
        }
    }
}