using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (PlayerPrefs.HasKey("posicionX"))
        {
            float x = PlayerPrefs.GetFloat("posicionX");
            float y = PlayerPrefs.GetFloat("posicionY");
            float z = PlayerPrefs.GetFloat("posicionZ");
            player.transform.position = new Vector3(x, y, z);
        }
    }

    private void OnApplicationQuit()
    {
        print("OnApplicationQuit");
        PlayerPrefs.SetFloat("posicionX", player.transform.position.x);
        PlayerPrefs.SetFloat("posicionY", player.transform.position.y);
        PlayerPrefs.SetFloat("posicionZ", player.transform.position.z);
        PlayerPrefs.Save();
    }
}
