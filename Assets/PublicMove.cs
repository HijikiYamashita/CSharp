using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicMove : MonoBehaviour
{
    public float speed = 0.01f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, speed);
    }
}
