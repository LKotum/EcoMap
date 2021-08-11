using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Controller_new : MonoBehaviour
{
   [SerializeField]
    public float speed;
       void Start()
    {

    }

    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        float delTime = Time.deltaTime;

        transform.position += new Vector3(transform.position.x * hor * speed * Time.deltaTime, 0, 0);
        //transform.Translate(transform.forward * ver * delTime * speed, Space.World);
        
    }   
}
