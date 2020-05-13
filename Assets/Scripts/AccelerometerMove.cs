using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerMove : MonoBehaviour { 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //taking accelero meter input
        float temp = Input.acceleration.x;
        Debug.Log(temp);
        transform.Translate(0, temp, 0);


    }
}
