using AIActors.Contexts;
using States;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {
    private State currentState;
    private List<State> states;
    private AIActorContext context;

    public State GetState<T>() where T : State {
        foreach(State state in states) {
            if(state is T) {
                return state;
            }
        }
        return null;
    }

    public AIActorContext GetContext() {
        return context;
    }

    public virtual void Initialize(List<State> states, State rootState, AIActorContext context) {
        currentState = new State(this);
        currentState = rootState;
        this.states = states;
        this.context = context;
    }

    public virtual void UpdateState() {
        currentState = currentState.Evaluate();
    }
}
