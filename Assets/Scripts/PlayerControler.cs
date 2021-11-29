using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed = 10.0f;
    private float horizontalInput;
    private float verticalInput;

   
    // Update is called once per frame
    void Update()
    {
        //Tomamos eje horizontal del Input Manager
        horizontalInput = Input.GetAxis("Horizontal");
        //Tomamos eje vertical del Imput Manager
        verticalInput = Input.GetAxis("Vertical");
        //Movimiento hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        //Movimiento lateral
        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

        //Rotacion
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
