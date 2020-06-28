using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabStart : MonoBehaviour
{
    public GameObject ball;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ball, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
