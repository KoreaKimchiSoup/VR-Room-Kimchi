using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustumRotate : MonoBehaviour
{
    public float rotationSpeed = 10f;

    void Update()
    {
        transform.rotation = Quaternion.Euler(0, rotationSpeed, 0);
    }
}
