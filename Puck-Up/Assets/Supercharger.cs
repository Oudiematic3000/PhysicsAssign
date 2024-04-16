using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supercharger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private CircleCollider2D circleCollider;
    [SerializeField]
    private Puck puck;
    [SerializeField]
    private LogicManagerScript lms;
    private float count=0;
    void Start()
    {
        puck=GameObject.Find("Puck").GetComponent<Puck>();
        lms=GameObject.Find("LogicManager").GetComponent<LogicManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Puck"))
        {
            puck.superCharge();
            if (puck.playerLastTouch)
            {
                lms.playerAddScore();
            }
            else
            {
                lms.AIAddScore();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        puck.uncharge();
    }
    // Update is called once per frame
    void Update()
    {
        if (count < 3)
        {
            count += Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
