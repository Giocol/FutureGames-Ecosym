using System;
using System.Collections.Generic;
using UnityEngine;

namespace States {
    public class LookForTargetState : State{

        public LookForTargetState(StateMachine stateMachine) : base(stateMachine) { }

        public override State Evaluate() {
            //find water
            Vector3 actorPosition = stateMachine.GetContext().aiActor.transform.position;
            GameObject[] targetGameObjects = stateMachine.GetContext().targets;
            stateMachine.GetContext().currentTarget = GetClosestTarget(actorPosition, targetGameObjects);
            return stateMachine.GetState<ReachTargetState>();
        }

        private GameObject GetClosestTarget(Vector3 sourcePosition, GameObject[] targets) {
            Array.Sort(targets, (a, b) => {
                return Vector3.Distance(a.transform.position, sourcePosition).CompareTo(Vector3.Distance(b.transform.position, sourcePosition));
            });
            return targets[0];
        }
    }
}
