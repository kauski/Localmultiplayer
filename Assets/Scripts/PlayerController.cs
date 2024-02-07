using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 20.0f;
    public float turnSpeed;
    public bool player;
    public float acceleration;
    public float maxSpeed;
    public float minSpeed;
    //p1 
    public float horizontalInput;
    public float forwardInput;
    private float P1currentSpeed;
    

    //p2 
    public float horizontalInputP2;
    public float forwardInputP2;
    private float p2currentSpeed;
    private
    // Start is called before the first frame update
    void Start()
    {
        P1currentSpeed = 0.0f;
        p2currentSpeed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //p1 inputs
        if (player == false)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
            //movement forward/backward

            
            float P1accelerationAmount = acceleration * forwardInput * Time.deltaTime;
            P1currentSpeed = Mathf.Clamp(P1currentSpeed + P1accelerationAmount, minSpeed, maxSpeed);
            transform.Translate(P1currentSpeed * Time.deltaTime * Vector3.forward);
            //rotate car
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        }
        else
        {

            //p2 inputs
            horizontalInputP2 = Input.GetAxis("HorizontalP2");
            forwardInputP2 = Input.GetAxis("VerticalP2");
            float P2accelerationAmount = acceleration * forwardInputP2 * Time.deltaTime;
            p2currentSpeed = Mathf.Clamp(p2currentSpeed + P2accelerationAmount, minSpeed, maxSpeed);

            //movement forward/backward
            transform.Translate(p2currentSpeed * Time.deltaTime * Vector3.forward);
            //rotate car
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInputP2);
        }
    }
}
