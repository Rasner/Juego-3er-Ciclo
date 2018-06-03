using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public static PlayerController instance;
    public bool zona;
    // Use this for initialization
    void Start()
    {
        instance = this;
        zona = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
