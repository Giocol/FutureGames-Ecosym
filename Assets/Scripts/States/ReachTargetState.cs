namespace States {
    public class ReachTargetState : State {
        public ReachTargetState(StateMachine stateMachine) : base(stateMachine) { }

        public override State Evaluate() {

            // move towards target

            return this;
        }
    }
}
