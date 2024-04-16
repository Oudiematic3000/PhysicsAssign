using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mallet : MonoBehaviour

{
   
    private Vector3 offset;
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private CountDown countDown;

    private void Start()
    {
        transform.position = new Vector3 (0, -8, 0);
    }

    public void resetMallet()
    {
        transform.position = new Vector3(0, -8, 0);

    }
    void OnMouseDown()
  
    {
        if (countDown.done)
        {
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        }
        }

    void OnMouseDrag()
    {
        if (countDown.done)
        {
            Vector3 screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            Vector3 pos = Camera.main.ScreenToWorldPoint(screenPoint) + offset;
            rb.MovePosition(pos);
        }
    }

    public float GetVelocity()
    {
        return rb.velocity.magnitude;
    }

}
