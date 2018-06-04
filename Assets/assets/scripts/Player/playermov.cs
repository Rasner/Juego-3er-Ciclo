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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cancer")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "CTrigger")
        {
            PlayerController.instance.zona = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "CTrigger")
        {
            PlayerController.instance.zona = false;
        }
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