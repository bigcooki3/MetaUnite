﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        transform.LookAt(2 * transform.position - target.position);
    }
}
