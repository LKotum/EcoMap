using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float forceMove;
    public float forceRotate;
    public Vector3 move;
    public Vector3 moveCamera;
    public Transform mainCamera;


    void Start()
    {
        //mainCamera = this.gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        move = mainCamera.transform.forward;
        moveCamera = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        this.gameObject.transform.Translate(Input.GetAxis("Vertical") * move * Time.deltaTime * forceMove, Space.Self);
        if(Input.GetKey(KeyCode.E)){
            mainCamera.transform.Rotate(.0f, 1.0f * forceRotate, .0f, Space.World);
        }

        if(Input.GetKey(KeyCode.Q)){
            mainCamera.transform.Rotate(.0f, -1.0f * forceRotate, .0f, Space.World);
        }
        
    }
}
