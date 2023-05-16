using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0f, 100f * Time.deltaTime, 0f, Space.Self);
    }
}