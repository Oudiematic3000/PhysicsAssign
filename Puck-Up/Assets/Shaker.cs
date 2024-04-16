using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float duration;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator shake()
    {
        Vector3 startPos= transform.position;
        float count = 0;

        while(count<duration) {  
            transform.position = startPos + new Vector3(Random.Range(-0.1f,0.1f), Random.Range(-0.1f, 0.1f),0);
            Debug.Log("Shake");
            count += Time.deltaTime;
            yield return null;
        }
        transform.position = startPos;
        
    }
}
