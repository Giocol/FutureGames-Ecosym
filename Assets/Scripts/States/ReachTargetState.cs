namespace States {
    public class ReachTargetState : State {
        public ReachTargetState(StateMachine stateMachine) : base(stateMachine) { }

        public override State Evaluate() {
            stateMachine.GetContext().actorScript.MoveTowardsTargetPosition(stateMachine.GetContext().currentTarget.transform.position);
            return this;
        }
    }
}
