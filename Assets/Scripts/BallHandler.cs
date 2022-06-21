using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
    public static Color BaseColor = Color.magenta;
    public GameObject ball;

    public float speed = 100;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            HitBall();
        }
    }

    private void HitBall()
    {
        var go = Instantiate(ball, new Vector3(0f, 0f, -8f), Quaternion.identity);
        go.GetComponent<MeshRenderer>().material.color = BaseColor;
        go.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }
}