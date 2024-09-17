using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hancurDalam : MonoBehaviour
{
    public float dalam;

    public void Start()
    {
        GameObject.Destroy(gameObject, dalam);
    }
}
