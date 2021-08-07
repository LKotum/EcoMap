using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zoom : MonoBehaviour
{
    // Start is called before the first frame update
    private float zoomSpeed;

    void Start()
    {
        zoomSpeed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        float variable = Input.GetAxis("Mouse ScrollWheel");

        if (variable > 0) {
            this.gameObject.transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime,  Space.Self);
        }
        if (variable < 0) {
            this.gameObject.transform.Translate(Vector3.forward * -zoomSpeed * Time.deltaTime,  Space.Self);
        }   
        // if(Input.GetAxis("Mouse ScrollWheel") != 0){
        //     this.gameObject.transform.position += transform.forward * Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        // }

    }

    
}
