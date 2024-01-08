using AIActors.Contexts;

namespace States
{
    public class State {
        protected StateMachine stateMachine;
        protected AIActorContext context;

        public State(StateMachine stateMachine) {
            this.stateMachine = stateMachine;
            this.context = stateMachine.GetContext();
        }

        public virtual State Evaluate() {
            return this;
        }
    }
}
