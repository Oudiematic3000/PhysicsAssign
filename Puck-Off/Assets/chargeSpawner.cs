using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chargeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    private float count = 0;
    [SerializeField]
    private float rate;
    [SerializeField]
    private Supercharger supCh;
    [SerializeField]
    private CountDown countdown;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown.done)
        {
            if (count < rate)
            {
                count += Time.deltaTime;
            }
            else
            {

                float xRand = Random.Range(-5, 5);
                float yRand= Random.Range(-6, 6);
                while((xRand>-2 && xRand < 2) && (yRand > -3 && yRand < 3))
                {
                    xRand = Random.Range(-5, 5);
                    yRand = Random.Range(-6, 6);
                }
                Instantiate(supCh, new Vector3(xRand, yRand, 0), Quaternion.identity);
                count = 0;
            }
        }
        else
        {
            count = 0;
        }
    }
}
