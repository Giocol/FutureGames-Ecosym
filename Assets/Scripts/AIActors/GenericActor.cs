using AIActors.Contexts;
using States;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AIActors {
    public class GenericActor : MonoBehaviour {
        [SerializeField] protected AIActorContext context;
        protected List<State> validStates;
        protected StateMachine stateMachine;

        protected virtual void Awake() {
            stateMachine = gameObject.AddComponent<StateMachine>();
            stateMachine.Initialize(validStates, validStates[0], context);
        }

    }
}
