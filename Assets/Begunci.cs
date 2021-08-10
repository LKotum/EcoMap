using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Begunci : MonoBehaviour
{
    public GameObject SliderMov, SliderRot, Controller;
    public Text Move, Rotate, InputFieldMove, InputFieldRotate;
    private float SliderMoveValue, SliderRotateValue;
   
    void Start()
    {
        // SliderMoveValue = SliderMov.GetComponent<Slider>().value;
        // SliderRotateValue = SliderRot.GetComponent<Slider>().value;
    }

    void Update()
    {
        Move.text = Convert.ToString(Controller.GetComponent<Controller>().forceMove);
        Rotate.text = Convert.ToString(Controller.GetComponent<Controller>().forceRotate);

        // SliderMov.GetComponent<Slider>().value = Convert.ToInt32(InputFieldMove.text);
        // SliderRot.GetComponent<Slider>().value = Convert.ToInt32(InputFieldRotate.text);
    }
    public void click1()
    {  
        if(Convert.ToInt32(InputFieldMove.text) >= 0.5 && Convert.ToInt32(InputFieldMove.text) <= 5){
            SliderMov.GetComponent<Slider>().value = Convert.ToInt32(InputFieldMove.text);
            Controller.GetComponent<Controller>().forceMove = Convert.ToInt32(InputFieldMove.text);
        }  
    }
    public void click2()
    {
        if(Convert.ToInt32(InputFieldRotate.text) >= 0.5 && Convert.ToInt32(InputFieldRotate.text) <= 3){
            SliderRot.GetComponent<Slider>().value = Convert.ToInt32(InputFieldRotate.text);
            Controller.GetComponent<Controller>().forceRotate = Convert.ToInt32(InputFieldRotate.text);
        }  
    }
}
