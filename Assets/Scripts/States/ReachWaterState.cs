namespace States {
    public class ReachWaterState : State {
        public ReachWaterState(StateMachine stateMachine) : base(stateMachine) { }

        public override State Evaluate() {

            // move towards target

            return this;
        }
    }
}
