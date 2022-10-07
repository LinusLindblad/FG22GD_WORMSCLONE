using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryRotation : MonoBehaviour
{
    private void Update()
    {
        //transform.Rotate(transform.rotation.x, transform.rotation.y + 2, transform.rotation.z);
        Vector3 rotSpeed = new Vector3(0, 1, 0);
        transform.Rotate(rotSpeed);
    }
}
