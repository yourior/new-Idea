﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBall : MonoBehaviour {

    public int RollSpeed;
    public Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 Roll = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(Roll * RollSpeed);

    }
}