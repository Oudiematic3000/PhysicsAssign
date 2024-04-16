using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private LogicManagerScript lms;
    [SerializeField]
    private Puck puck;
    [SerializeField]
    private CountDown countDown;
    [SerializeField]
    private Mallet mallet;
    [SerializeField]
    private AIScript ai;
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
            countDown.resetCount();
            ai.resetMallet();
            mallet.resetMallet();
            
        }
        else
        {
            lms.playerAddScore();
            puck.resetPuck();
            countDown.resetCount();
            ai.resetMallet();
            mallet.resetMallet();
        }
    }
}
