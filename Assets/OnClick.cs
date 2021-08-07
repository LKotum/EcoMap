using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject cameraTransform;
    public GameObject cameraPosition;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        cameraTransform.GetComponent<Controller>().destination = cameraPosition.transform.position;
        cameraTransform.GetComponent<Controller>().movePosition = true;
    }
}
