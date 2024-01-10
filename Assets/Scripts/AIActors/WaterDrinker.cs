using AIActors.Contexts;
using States;
using System.Linq;
using UnityEngine;

namespace AIActors {
    public class WaterDrinker : GenericActor {
        protected override void FillValidStatesList() {
            validStates.Add(new LookForTargetState(stateMachine));
            validStates.Add(new ReachTargetState(stateMachine));
            validStates.Add(new DrinkWaterState(stateMachine));
        }

        protected override void PopulateContext() {
            base.PopulateContext();
            context.aiActor = gameObject;
            context.targetTag = "Water";
        }
    }
}
