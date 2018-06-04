using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{

    public Transform player;
    public Transform tpdwn;
    public Transform tudi;
    //public Vector3 offset;
    public float speed;

    // Use this for initialization
    void Start()
    {
        //rotar = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.instance.zona == false)
        {
            transform.position = Vector3.Lerp(transform.position, tudi.position, Time.deltaTime * speed);

            Vector3 currentAngle = new Vector3(
                Mathf.LerpAngle(transform.rotation.eulerAngles.x, tudi.rotation.eulerAngles.x, Time.deltaTime * speed),
                Mathf.LerpAngle(transform.rotation.eulerAngles.y, tudi.rotation.eulerAngles.y, Time.deltaTime * speed),
                Mathf.LerpAngle(transform.rotation.eulerAngles.z, tudi.rotation.eulerAngles.z, Time.deltaTime * speed));

            transform.eulerAngles = currentAngle;

            transform.rotation = Quaternion.Lerp(transform.rotation, tudi.rotation, Time.deltaTime * speed);
            //transform.position = new Vector3(player.position.x, 60f, -1f);
        }

        if (PlayerController.instance.zona == true)
        {
            transform.position = Vector3.Lerp(transform.position, tpdwn.position, Time.deltaTime * speed);

            Vector3 currentAngle = new Vector3(
                Mathf.LerpAngle(transform.rotation.eulerAngles.x, tpdwn.rotation.eulerAngles.x, Time.deltaTime * speed),
                Mathf.LerpAngle(transform.rotation.eulerAngles.y, tpdwn.rotation.eulerAngles.y, Time.deltaTime * speed),
                Mathf.LerpAngle(transform.rotation.eulerAngles.z, tpdwn.rotation.eulerAngles.z, Time.deltaTime * speed));

            transform.eulerAngles = currentAngle;

            transform.rotation = Quaternion.Lerp(transform.rotation, tpdwn.rotation, Time.deltaTime * speed);
        }
    }
}
