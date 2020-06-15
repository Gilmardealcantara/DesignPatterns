using System;

namespace GuardiansOfTheCode.Multiplayer
{
    public class OnTrialState : IState
    {
        private SubscriptionManager _manager;

        public OnTrialState(SubscriptionManager manager)
        {
            _manager = manager;
        }

        public void Expire()
        {
            Console.WriteLine("Trial Expired");
            _manager.CurrentState = new TrialExpiredState(_manager);
        }

        public void Pay()
        {
            Console.WriteLine("Paid membership acquired");
            _manager.CurrentState = new PaidState(_manager);
        }
    }
}