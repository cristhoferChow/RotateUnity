using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class rotateMono : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    public float speed;
    public GameObject cubo;

    public Transform objectToOrbit;


    private void Update()
    {
        transform.RotateAround(cubo.transform.position, Vector3.up, speed*Time.deltaTime);
        if( objectToOrbit == null)
        {
            return;
        }
      
        Vector3 originalVector = objectToOrbit.forward * 5;
        Vector3 offset = Quaternion.Euler(0, 30, 0) * originalVector;
        transform.position = objectToOrbit.forward + offset;


    }
}
