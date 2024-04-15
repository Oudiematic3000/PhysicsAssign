using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private CircleCollider2D circleCollider;
    private RaycastHit2D rayDestination;

    private Vector2 lastVelocity;
    [SerializeField]
    private float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {

        rb.gravityScale = 0;


        rb.velocity= Random.insideUnitSphere;

    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = rb.velocity;
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed*Time.deltaTime;
        }

        rayDestination=Physics2D.Raycast(transform.position, rb.velocity.normalized, 50, 3);
    }

    public Vector2 getRayHit()
    {

        return rayDestination.point;
    }
}



