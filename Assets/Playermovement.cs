using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Playermovement : MonoBehaviour
{
    //int i = 0;
    //string s;
    public Rigidbody rb;
    public float forwardforce = 10f;
    public float sidewardforce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");
        //rb.useGravity = false;
        //rb.AddForce(0, 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        //i++;
        //s = Convert.ToString(i);
        //Debug.Log("This is frame number " + s);
        if(Input.GetKey("up"))
        {
            rb.AddForce(0, 0, forwardforce);
        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -forwardforce);
        }
        if(Input.GetKey("left"))
        {
            rb.AddForce(-sidewardforce, 0, 0);
        }
        if(Input.GetKey("right"))
        {
            rb.AddForce(sidewardforce, 0, 0);
        }
    }/*
    void FixedUpdate()
    {

    }*/
}
