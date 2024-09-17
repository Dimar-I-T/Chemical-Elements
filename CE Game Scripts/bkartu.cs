using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bkartu : MonoBehaviour
{
    public string target;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ar")
        {
            Debug.Log("Ada");
        }
    }
}
