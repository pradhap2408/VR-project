using UnityEngine;

public class MoveLoop : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 5f;

    private Transform target;

    void Start()
    {
        transform.position = pointA.position; // Start at Point A
        target = pointB;                      // First target is Point B
    }

    void Update()
    {
        // Move towards the current target
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        // Check if the object reached the target
        if (transform.position == target.position)
        {
            // Switch the target
            if (target == pointB)
            {
                target = pointA;
            }
            else
            {
                target = pointB;
            }
        }
    }
}