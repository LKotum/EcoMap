﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject cameraTransform;
    public GameObject cameraPosition;
    public GameObject Buttion;
    public GameObject Panel_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        cameraTransform.GetComponent<Controller>().destination = cameraPosition.transform.position;
        cameraTransform.GetComponent<Controller>().vra = cameraPosition.transform.rotation;
        cameraTransform.GetComponent<Controller>().movePosition = true;
        activePanel();
        activeButtion();
    }


    void activePanel(){
        Panel_1.SetActive(true);
    }
    void activeButtion(){
        Buttion.SetActive(true);
    }
}
