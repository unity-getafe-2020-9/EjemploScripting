using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Pollo : MonoBehaviour
{
    Rigidbody rigidbody;
    public float fuerza;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
    }
    private void Saltar()
    {
        print("Saltando");
        Vector3 impulso = new Vector3(0, fuerza*1.5f, fuerza);
        rigidbody.AddForce(impulso, ForceMode.Impulse);
    }
}
