using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Controller : MonoBehaviour
{
    public float forceMove;
    public float forceRotate;
    public Transform mainCamera;

    public Text X,Y,Z;
    public float speed = 0.01f;
    public Vector3 destination;
    public Quaternion vra;

    public bool movePosition = false;

<<<<<<< HEAD
    void Start()
    {
        vra = transform.rotation;
=======
    private float variable;
    public float zoomSpeed;

    void Start()
    {
        zoomSpeed = 100f;
>>>>>>> origin/main
        destination = transform.position;
        mainCamera = this.gameObject.GetComponent<Transform>();
    }

    void Update(){
    
       
        if(movePosition){
            transform.position = Vector3.Lerp(transform.position, destination, speed);
            transform.rotation = Quaternion.Lerp(transform.rotation, vra, speed);
            if(Vector3.Distance(transform.position, destination) < 5f) movePosition = false;
            if(Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Mouse2)) movePosition = false;
        }else{
            X.text = "X = " + Convert.ToString(Math.Round(mainCamera.position.x, 2));
            Z.text = "Z = " + Convert.ToString(Math.Round(mainCamera.position.z, 2));
            Y.text = Convert.ToString(Math.Round(mainCamera.position.y, 2));

            mainCamera.position += mainCamera.forward * forceMove * Input.GetAxis("Vertical");
            mainCamera.position += mainCamera.right * forceMove * Input.GetAxis("Horizontal");
            
            if(Input.GetKey(KeyCode.E)){
                mainCamera.transform.Rotate(.0f, 1.0f * forceRotate, .0f, Space.World);
            }

            if(Input.GetKey(KeyCode.Q)){
                mainCamera.transform.Rotate(.0f, -1.0f * forceRotate, .0f, Space.World);
            }

            if(Input.GetKey(KeyCode.Z)){
                mainCamera.position += mainCamera.up * forceRotate;
            }

            if(Input.GetKey(KeyCode.X)){
                mainCamera.position -= mainCamera.up * forceRotate;
            }
        }
   
    }   
}
