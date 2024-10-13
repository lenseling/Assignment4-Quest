using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 originalPosition;
    public float maxDistance = 3f; // Maximum distance before the ball respawns
    private Rigidbody rb;

    private void Start()
    {
        originalPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, originalPosition) > maxDistance)
        {
            RespawnBall();
        }
    }

    private void RespawnBall()
    {
        transform.position = originalPosition;

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
