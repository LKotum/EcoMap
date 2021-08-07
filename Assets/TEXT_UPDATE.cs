using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TEXT_UPDATE : MonoBehaviour
{
    public Transform Camera;
    public Text X,Y,Z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        X.text = "X = " + Convert.ToString(Camera.position.x);
        X.text = "Z = " + Convert.ToString(Camera.position.z);
        X.text = Convert.ToString(Camera.position.y);

    }
}
