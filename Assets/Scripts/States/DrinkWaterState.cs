using UnityEngine;

namespace States {
    public class DrinkWaterState : State{
        public DrinkWaterState(StateMachine stateMachine) : base(stateMachine) { }

        public override State Evaluate() {
            GameObject.Destroy(stateMachine.GetContext().currentTarget);
            return stateMachine.GetState<LookForTargetState>();
        }
    }
}
