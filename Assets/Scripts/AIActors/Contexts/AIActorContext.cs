using UnityEngine;

namespace AIActors.Contexts {
    [CreateAssetMenu(menuName = "Scriptable Objects/AIActorContext")]
    public class AIActorContext : ScriptableObject {
        public GameObject aiActor;
        public GenericActor actorScript;
        public GameObject[] targets;
        public GameObject currentTarget;
    }
}
