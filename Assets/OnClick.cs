using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject cameraTransform;
<<<<<<< HEAD
    public GameObject cameraPosition;
=======
>>>>>>> 7a3a6667df152a33f145bf00edf561f4710e2210
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
<<<<<<< HEAD
        cameraTransform.GetComponent<Controller>().destination = cameraPosition.transform.position;
        cameraTransform.GetComponent<Controller>().vra = cameraPosition.transform.rotation;
=======
        cameraTransform.GetComponent<Controller>().destination = transform.position;
>>>>>>> 7a3a6667df152a33f145bf00edf561f4710e2210
        cameraTransform.GetComponent<Controller>().movePosition = true;
    }
}
