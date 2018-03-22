using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTransform : MonoBehaviour
{
    Vector3 origin;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        origin = gameObject.transform.position;
    }
    public void SetPosition()
    {
        gameObject.transform.position = origin;
        rb.velocity = new Vector3(0, 0, 0);
    }
}
