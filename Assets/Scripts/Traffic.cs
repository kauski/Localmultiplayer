using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic : MonoBehaviour
{
    public float forwardSpeed = 20.0f;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //movement forward/backward
        transform.Translate(forwardSpeed * Time.deltaTime * Vector3.forward);
        
       
    }
}
