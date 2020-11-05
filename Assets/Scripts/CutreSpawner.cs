using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutreSpawner : MonoBehaviour
{
    public GameObject prefab;
    public int amount;
    public float offsetX;
    public float offsetY;
    void Start()
    {
        for(int i = 0; i < amount; i++)
        {
            Vector3 pos = new Vector3(
                Random.Range(transform.position.x - offsetX, transform.position.x + offsetX),
                Random.Range(transform.position.y, transform.position.y + offsetY),
                transform.position.z
            );
            Instantiate(prefab, pos, transform.rotation);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
