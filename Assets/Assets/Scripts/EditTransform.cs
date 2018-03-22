using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditTransform : MonoBehaviour
{
    public Vector3 Position;
    public float Scale;
    Vector3 vectorScale;
    void Update()
    {
        vectorScale = new Vector3(Scale, Scale, Scale);
        gameObject.transform.position = Position;
        gameObject.transform.localScale = vectorScale;
    }
}
