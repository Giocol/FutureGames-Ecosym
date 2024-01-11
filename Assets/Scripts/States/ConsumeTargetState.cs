using UnityEngine;

namespace States {
    public class ConsumeTargetState : State{
        public ConsumeTargetState(StateMachine stateMachine) : base(stateMachine) { }

        public override State Evaluate() {
            GameObject.Destroy(stateMachine.GetContext().currentTarget);
            return stateMachine.GetState<LookForTargetState>();
        }
    }
}
