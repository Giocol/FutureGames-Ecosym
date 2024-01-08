using States;
using System.Linq;
using UnityEngine;

namespace AIActors {
    public class WaterDrinker : GenericActor {
        protected override void Awake() {
            base.Awake();
            validStates.Add(new LookForWaterState(stateMachine));
        }
    }
}
