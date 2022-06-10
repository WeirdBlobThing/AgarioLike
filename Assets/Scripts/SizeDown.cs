using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeDown : MonoBehaviour
{
    public float Speed;
    public float Decrease;

    void Start()
    {
        InvokeRepeating("ScaleDown", 0, Speed);
    }

    void ScaleDown()
    {
        transform.localScale -= new Vector3(Decrease, Decrease, Decrease);
    }
}
