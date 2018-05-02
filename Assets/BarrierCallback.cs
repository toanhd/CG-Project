﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierCallback : MonoBehaviour
{
    public Transform start;
    public Transform end;

    public float speed;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(start.position, end.position, speed);
    }
}