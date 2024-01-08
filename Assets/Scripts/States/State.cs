using AIActors.Contexts;

namespace States
{
    public class State {
        protected StateMachine stateMachine;

        public State(StateMachine stateMachine) {
            this.stateMachine = stateMachine;
        }

        public virtual State Evaluate() {
            return this;
        }
    }
}
