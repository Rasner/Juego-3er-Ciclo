using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermov : MonoBehaviour
{
    public VirtualJoystick joystick;
    public float speed;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(speed * joystick.InputDirection * Time.deltaTime);
    }

    /*public void SButton (bool salto)
    {
        if (salto)
        {
            transform.Translate(speed *  * Time.deltaTime);
        }
    }
    */
}