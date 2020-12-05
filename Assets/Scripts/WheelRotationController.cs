using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotationController : MonoBehaviour
{
    float rotSpeed = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }
        transform.Rotate(this.rotSpeed, 0, 0);

        this.rotSpeed *= 0.99f;
    }
}
