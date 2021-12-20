namespace CpuStateMachine
{
    public class StateMachine
    {
        private State currentState;
        public bool onChanging;
        private State nextState;

        public void ChangeState(State state)
        {
            nextState = state;
            onChanging = true;
        }

        public void Update()
        {
            if (currentState != null)
                currentState.UpdateState();
            if (onChanging)
            {
                if (currentState != null)
                    currentState.ExitState();
                currentState = nextState;
                onChanging = false;
                currentState.EnterState();
            }
        }
    }
}