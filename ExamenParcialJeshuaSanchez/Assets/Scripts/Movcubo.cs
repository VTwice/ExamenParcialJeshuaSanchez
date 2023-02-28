using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movcubo : MonoBehaviour
{
 
    public float speed = 5f;
 
    public float rotationspeed = 50f;


 
    void Update()
    {

    float horizontalInput = Input.GetAxis("Horizontal");
    float vertivalInput = Input.GetAxis("Vertical");

    Vector3 movementDirection = new Vector3(horizontalInput, 0, vertivalInput);
    movementDirection.Normalize();

    transform.position = transform.position + movementDirection * speed * Time.deltaTime;

    if (movementDirection != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementDirection), rotationspeed * Time.deltaTime);
}
}