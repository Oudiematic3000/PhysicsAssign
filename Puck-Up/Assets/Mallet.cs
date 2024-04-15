using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mallet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Camera cam;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(cam.ScreenToWorldPoint(Input.mousePosition).x, cam.ScreenToWorldPoint(Input.mousePosition).y, 0);
        
        
    }
}
