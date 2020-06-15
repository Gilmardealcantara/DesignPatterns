namespace GuardiansOfTheCode.Multiplayer
{
    public class SubscriptionManager
    {
        public IState CurrentState;

        public SubscriptionManager()
        {
            CurrentState = new OnTrialState(this);
        }

        public void Expire()
        {
            CurrentState.Expire();
        }
        public void Pay()
        {
            CurrentState.Pay();
        }

    }
}