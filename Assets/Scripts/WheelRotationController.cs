using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotationController : MonoBehaviour
{
    float rotSpeed = 0;
    public GameObject wheel;

    void Update()
    {
        wheel.transform.Rotate(this.rotSpeed, 0, 0);

        this.rotSpeed *= 0.99f;
    }

    public void RotateWheel()
    {
        this.rotSpeed = 10;
    }
}
