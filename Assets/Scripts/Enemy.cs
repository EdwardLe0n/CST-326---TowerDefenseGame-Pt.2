using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 10f;

    private Transform target;
    private int waypointIndex = 0;

    void Start()
    {

        target = Waypoints.points[0];

    }

    void Update()
    {
        // Checks the current direction by comparing the current position to the next waypoint
        Vector3 dir = target.position - transform.position;

        // First normalizes the direction vector
        // Then multiplies that normalized vector by the enemies speed and by Time.deltaTime
        // Finally the code tells the system that it will move this enemy to the direction multiplied by all that
        // ... using the translate function

        transform.Translate(dir.normalized * speed * Time.deltaTime);
        
        // If the enemy is close enough to the waypoint, then it will look at 
        // ... the next waypoint as the new target
        
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

    }

    // Gets the next wavepoint
    void GetNextWaypoint()
    {

        // If there are no more waypoints then the enemy will destroy itself
        if (waypointIndex >= Waypoints.points.Length - 1)
        {

            Destroy(gameObject);

            // return statement to avoid running more code
            return;

        }

        waypointIndex++;
        target = Waypoints.points[waypointIndex];

    }

}
