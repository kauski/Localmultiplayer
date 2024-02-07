using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform target;
    public float distance = 5.0f;      
    public float height = 10.0f;      
    public float smoothSpeed = 5.0f;   
    public float rotationSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!target)
            return;
        // Calculate the desired rotation angle
        float desiredRotationAngle = target.eulerAngles.y;

        // Calculate the desired camera position
        Vector3 desiredPosition = target.position - Quaternion.Euler(0, desiredRotationAngle, 0) * Vector3.forward * distance;
        desiredPosition.y = target.position.y + height;

        // Smoothly move and rotate the camera towards the desired position and rotation
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * smoothSpeed);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, desiredRotationAngle, 0), Time.deltaTime * rotationSpeed);
    }
}
