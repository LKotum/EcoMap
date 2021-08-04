using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Controller : MonoBehaviour
{
    public float forceMove = 1;
    public float forceRotate = 1;
    //public Transform mainCamera;

    public Text X, Y, Z;
    public float speed = 0.01f;
    public Vector3 destination;
    public bool movePosition = false;


    void Start()
    {
        destination = transform.position;
    }

    void Update()
    {
        if (movePosition)
        {
            transform.position = Vector3.Lerp(transform.position, destination, speed);
            if (Vector3.Distance(transform.position, destination) < 5f) movePosition = false;
        }
        else
        {
            X.text = "X = " + Convert.ToString(Math.Round(this.gameObject.GetComponent<Transform>().position.x, 2));
            Z.text = "Z = " + Convert.ToString(Math.Round(this.gameObject.GetComponent<Transform>().position.z, 2));
            Y.text = Convert.ToString(Math.Round(this.gameObject.GetComponent<Transform>().position.y, 2));

            this.gameObject.GetComponent<Transform>().position += this.gameObject.GetComponent<Transform>().forward * forceMove * Input.GetAxis("Vertical");
            this.gameObject.GetComponent<Transform>().position += this.gameObject.GetComponent<Transform>().right * forceMove * Input.GetAxis("Horizontal");

            //this.gameObject.transform.Translate(Input.GetAxis("Vertical") * move * Time.deltaTime * forceMove, Space.Self);
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.GetComponent<Transform>().transform.Rotate(.0f, 1.0f * forceRotate, .0f, Space.World);
            }

            if (Input.GetKey(KeyCode.Q))
            {
                this.gameObject.GetComponent<Transform>().transform.Rotate(.0f, -1.0f * forceRotate, .0f, Space.World);
            }

            if (Input.GetKey(KeyCode.Z))
            {
                this.gameObject.GetComponent<Transform>().position += this.gameObject.GetComponent<Transform>().up * forceMove;
            }

            if (Input.GetKey(KeyCode.X))
            {
                this.gameObject.GetComponent<Transform>().position -= this.gameObject.GetComponent<Transform>().up * forceMove;
            }
        }
    }
}
