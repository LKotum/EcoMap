using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public GameObject target;

    void Start(){
        //target = gameObject.GetComponentInParent<Transform>().gameObject; (разобраться)
    }
    void Update()
    {
        Vector3 relativePos = target.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

    
}
