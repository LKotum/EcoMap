using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float forceMove;
    public float forceRotate;
    public Vector3 move;
    public Transform mainCamera;


    void Start()
    {
        mainCamera = this.gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        mainCamera.Translate(move * Time.deltaTime * forceMove, Space.World);
        if(Input.GetKey(KeyCode.E)){
            mainCamera.Rotate(.0f, 1.0f * forceRotate, .0f, Space.World);
        }

        if(Input.GetKey(KeyCode.Q)){
            mainCamera.Rotate(.0f, -1.0f * forceRotate, .0f, Space.World);
        }
        
    }
}
