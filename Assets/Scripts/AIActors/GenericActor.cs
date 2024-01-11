using AIActors.Contexts;
using States;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AIActors {
    public abstract class GenericActor : MonoBehaviour {
        [SerializeField] protected float distanceFromTargetThreshold = 0.5f;
        [SerializeField] protected AIActorContext context;
        [SerializeField] protected float movementSpeed = 5f;
        [SerializeField] protected float reachRange = 1f;
        protected List<State> validStates;
        protected StateMachine stateMachine;

        protected virtual void Awake() {
            validStates = new List<State>();
            stateMachine = gameObject.AddComponent<StateMachine>();
            context = ScriptableObject.CreateInstance<AIActorContext>();
            FillValidStatesList();
            PopulateContext();
            stateMachine.Initialize(validStates, validStates[0], context);
        }

        protected abstract void FillValidStatesList();

        protected virtual void PopulateContext() {
            context.aiActor = this.gameObject;
            context.actorScript = this;
        }

        public bool MoveTowardsTargetPosition(Vector3 targetPosition) {
            if(Vector3.Distance(this.transform.position, targetPosition) < reachRange) {
                return true;
            }
            else {
                this.transform.position = Vector3.MoveTowards(this.transform.position, targetPosition, movementSpeed * Time.deltaTime);
                return false;
            }
        }

        private void Update() {
            stateMachine.UpdateState();
        }

    }
}
