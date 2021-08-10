using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Begunci : MonoBehaviour
{
    public GameObject Controller;
    public Text Move, Rotate;
   
    void Start()
    {
        
    }

    void Update()
    {
        Move.text = Convert.ToString(Controller.GetComponent<Controller>().forceMove);
        Rotate.text = Convert.ToString(Controller.GetComponent<Controller>().forceRotate);
    }
    public void click1()
    {  
    
    }
    public void click2()
    {
           
    }
}
