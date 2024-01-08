using System;
using System.Collections.Generic;
using UnityEngine;

namespace States {
    public class LookForWaterState : State{

        public LookForWaterState(StateMachine stateMachine) : base(stateMachine) { }

        public override State Evaluate() {
            //find water
            Vector3 actorPosition = context.aiActor.transform.position;
            GameObject[] waterGameObjects = context.objectsToReach;

            return stateMachine.GetState<ReachWaterState>();
        }

        private Vector3 GetClosestWaterPosition(Vector3 sourcePosition, GameObject[] targets) {
            Array.Sort(targets, (a, b) => {
                return Vector3.Distance(a.transform.position, sourcePosition).CompareTo(Vector3.Distance(b.transform.position, sourcePosition));
            });

            return targets[0].transform.position;
        }
    }
}
