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
    [SerializeField]
    private CountDown countDown;
    // Start is called before the first frame update
    void Start()
    {

        rb.constraints = RigidbodyConstraints2D.FreezePosition;

        rb.gravityScale = 0;
        

    }

    // Update is called once per frame
    void Update()
    {
        if(!countDown.done)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }
        rb.constraints = RigidbodyConstraints2D.None;
        if (rb.velocity.magnitude < 0.1)
        {
            rb.velocity = Random.insideUnitSphere;
        }
        lastVelocity = rb.velocity;
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed*Time.deltaTime;
        }

        if(transform.position.x<-7.5 ||  transform.position.x>7 ||transform.position.y<-14 ||transform.position.y>14) {
            resetPuck();
        }
       
    }

   

    public void resetPuck()
    {
      

        transform.position = Vector2.zero;
        rb.velocity = Random.insideUnitSphere;
    }
}



