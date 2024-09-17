using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posisiAwal : MonoBehaviour
{
    public GameObject[] objek;

    public void Update()
    {
        foreach (GameObject o in objek)
        {
            o.transform.SetPositionAndRotation(new Vector3(Screen.width, Screen.height),
                                                transform.rotation);
        }

        Camera kamera = Camera.main;
        kamera.transform.SetPositionAndRotation(new Vector3(Screen.width, Screen.height, -15), transform.rotation);
        kamera.orthographicSize = Screen.height - 1;
    }
}
