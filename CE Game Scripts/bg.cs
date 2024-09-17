using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    public float skala = 1;

    public void Update()
    {
        transform.localScale = new Vector3(Screen.width * skala, Screen.height * skala);
    }
}
