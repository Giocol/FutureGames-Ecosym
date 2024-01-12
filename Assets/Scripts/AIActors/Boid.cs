using UnityEngine;

namespace AIActors {
    public class Boid : MonoBehaviour{
        [SerializeField] private float speed = 2f;
        [SerializeField] private float viewRadius = 3f;

        public float GetSpeed() {
            return speed;
        }

        public Boid[] GetClosestBoids() {
            Collider[] closestBoidsColliders = Physics.OverlapSphere(this.gameObject.transform.position, viewRadius); //TODO: optimize it with the NonAlloc version
            Boid[] closestBoids = new Boid[closestBoidsColliders.Length];
            for(int i = 0; i < closestBoidsColliders.Length; i++) {
                closestBoids[i] = closestBoidsColliders[i].gameObject.GetComponent<Boid>();
            }
            return closestBoids;
        }

        public void Move(Vector3 direction) {
            Vector3 velocity = direction * speed;
        }
    }
}
