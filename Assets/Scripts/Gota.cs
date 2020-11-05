using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gota : MonoBehaviour
{
    private Vector3 initialPosition;
    private void Awake()
    {
        
    }
    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
    }
    private void FixedUpdate()
    {
        
    }
    private void LateUpdate()
    {
        
    }

    private void OnBecameVisible()
    {
        //print("Visible");
    }
    private void OnBecameInvisible()
    {
        //print("Invisible");
        transform.position = initialPosition;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
