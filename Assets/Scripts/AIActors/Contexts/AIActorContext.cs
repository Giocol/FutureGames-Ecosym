using UnityEngine;

namespace AIActors.Contexts {
    [CreateAssetMenu(menuName = "Scriptable Objects/AIActorContext")]
    public class AIActorContext : ScriptableObject {
        public GameObject aiActor;
        public float movementSpeed;
        public GameObject[] targets;
        public GameObject currentTarget;
    }
}
