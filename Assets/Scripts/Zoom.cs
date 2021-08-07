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
        zoomSpeed = 500f;
    }

    // Update is called once per frame
    void Update()
    {
        float variable = Input.GetAxis("Mouse ScrollWheel");
        while(variable != 0){
            float i =+ variable;
            Debug.Log(i);
        }
        Debug.Log(Input.GetAxis("Mouse ScrollWheel"));

            this.gameObject.transform.Translate(Vector3.forward * -zoomSpeed * variable * Time.deltaTime,  Space.Self);  
    }
}
