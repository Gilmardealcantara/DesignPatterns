using System;

namespace GuardiansOfTheCode.Multiplayer
{
    public class TrialExpiredState : IState
    {
        private SubscriptionManager _manager;

        public TrialExpiredState(SubscriptionManager manager)
        {
            _manager = manager;
        }

        public void Expire()
        {
            throw new System.InvalidOperationException("Cannot expire an expire subscription");
        }

        public void Pay()
        {
            Console.WriteLine("Paid Membership");
            _manager.CurrentState = new PaidState(_manager);
        }
    }
}