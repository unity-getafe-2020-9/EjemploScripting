using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Ejemplo : MonoBehaviour
{
    Rigidbody rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
