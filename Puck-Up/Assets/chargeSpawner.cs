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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(count<rate)
        {
            count += Time.deltaTime;
        }
        else
        {
            Instantiate(supCh, new Vector3(Random.Range(-5, 5), Random.Range(-6, 6), 0), Quaternion.identity);
            count = 0;
        }
    }
}
