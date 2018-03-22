using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTrack : MonoBehaviour
{
    GameObject MetaCamera;
    //public float yFactor;
    public float zOffset;
    void Start()
    {
        MetaCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            (MetaCamera.transform.position.z + zOffset)
        );
    }
}
