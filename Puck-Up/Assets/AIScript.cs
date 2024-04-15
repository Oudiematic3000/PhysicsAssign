using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Puck puck;
    [SerializeField]
    private Rigidbody2D rb;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        /*  if (puck.transform.position.y > transform.position.y)
          {
              transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 8, 0), 10 * Time.deltaTime);
          }

          else if (puck.GetComponent<Rigidbody2D>().velocity.magnitude < 2 && puck.transform.position.y > 0)
          {
              transform.position = Vector3.MoveTowards(transform.position, new Vector3(puck.transform.position.x, puck.transform.position.y, 0), 50 * Time.deltaTime);

          }
          else if (puck.transform.position.y>4)
          {
              transform.position = Vector3.MoveTowards(transform.position, new Vector3(puck.transform.position.x, puck.transform.position.y, 0), 50 * Time.deltaTime);

          }
          else
          {
              
          }

  */
        Vector2 direction = (puck.transform.position - transform.position).normalized;
        if (puck.transform.position.y > transform.position.y)
        {
            rb.MovePosition(transform.position+(new Vector3(0, 8, 0) *1*Time.deltaTime));
        }
        else if (puck.GetComponent<Rigidbody2D>().velocity.magnitude < 2 && puck.transform.position.y > 0)
        {
            rb.MovePosition((Vector2)transform.position + (direction* 15 * Time.deltaTime));
        }
        else if (puck.transform.position.y > 5)
        {
            rb.MovePosition((Vector2)transform.position + (direction * 15 * Time.deltaTime));
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(puck.transform.position.x, 8, 0), 2 * Time.deltaTime);
        }
    }
}