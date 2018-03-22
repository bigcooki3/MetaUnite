using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    Vector3 newCoord = new Vector3(1, 3, 4);
    void Start()
    {
        transform.position = newCoord;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
