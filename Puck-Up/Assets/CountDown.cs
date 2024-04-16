using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI counter;
    public bool done = false;
    // Start is called before the first frame update
    public float count = 3;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 0)
        {
            count -= Time.deltaTime;
            Mathf.FloorToInt(count);
            counter.text = count.ToString("0");
        }
        else
        {
            done = true;
        }

    }

    public void resetCount()
    {
        done=false;
        counter.text = "3";
        count = 3;
    }   
}
