using AIActors.Contexts;
using States;
using System.Linq;
using UnityEngine;

namespace AIActors {
    public class WaterDrinker : GenericActor {
        [SerializeField] private float movementSpeed = 5f;

        protected override void FillValidStatesList() {
            validStates.Add(new LookForTargetState(stateMachine));
            validStates.Add(new ReachTargetState(stateMachine));
            validStates.Add(new DrinkWaterState(stateMachine));
        }

        protected override void PopulateContext() {
            context.aiActor = gameObject;
            context.targets = GetAllWaterSources();
            context.movementSpeed = movementSpeed;
        }

        private GameObject[] GetAllWaterSources() {
            return GameObject.FindGameObjectsWithTag("Water");
        }
    }
}
