namespace States {
    public class ReachTargetState : State {
        public ReachTargetState(StateMachine stateMachine) : base(stateMachine) { }

        public override State Evaluate() {
            if(stateMachine.GetContext().currentTarget) {
                bool isDestinationReached = stateMachine.GetContext().actorScript.MoveTowardsTargetPosition(stateMachine.GetContext().currentTarget.transform.position);
                if(!isDestinationReached) {
                    return this;
                }
                else {
                    return stateMachine.GetState<ConsumeTargetState>();
                }
            }
            else { // currenttarget doesn't exist anymore, go back to looking
                return stateMachine.GetState<LookForTargetState>();
            }
        }
    }
}
