using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            MethodOn();
        }
    }

    void MethodOn()
    {
        Debug.Log("Method_On");
    }
}
