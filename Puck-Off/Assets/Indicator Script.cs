using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Puck puck;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (puck.firstTouch)
        {
            spriteRenderer.enabled = false;
        }
        else
        {
            spriteRenderer.enabled=true;
        }
        if (puck.playerLastTouch)
        {
            spriteRenderer.color = Color.red;
        }
        else
        {
            spriteRenderer.color = Color.blue;
        }
    }
}
