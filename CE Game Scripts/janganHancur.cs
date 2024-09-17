using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class janganHancur : MonoBehaviour
{
    public void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
