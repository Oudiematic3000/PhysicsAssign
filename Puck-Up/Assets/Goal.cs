using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private LogicManagerScript lms;
    [SerializeField]
    private Puck puck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name == "PlayerGoal")
        {
           
            lms.AIAddScore();
            puck.resetPuck();
        }
        else
        {
            lms.playerAddScore();
            puck.resetPuck();
        }
    }
}
