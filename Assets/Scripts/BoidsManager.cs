using AIActors;
using System;
using UnityEngine;

public class BoidsManager : MonoBehaviour{
    [SerializeField] private int numberOfBoids;
    private Boid[] boids;
    private Vector3 direction;

    private void Update() {
        foreach(Boid boid in boids) {
            Boid[] context = boid.GetClosestBoids();
            direction = Vector3.zero;

            direction += Cohesion(boid, context);
            direction += Separation(boid, context);
            direction += Alignment(boid, context);

            boid.Move(direction);
        }
    }

    private Vector3 Alignment(Boid boid, Boid[] context) {
        throw new NotImplementedException();
    }

    private Vector3 Separation(Boid boid, Boid[] context) {
        throw new NotImplementedException();
    }

    private Vector3 Cohesion(Boid boid, Boid[] context) {
        throw new NotImplementedException();
    }
}
