using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float dirX, dirY;
    public float speed;
    public Joystick joystick;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        dirX = joystick.Horizontal * speed;
        dirY = joystick.Vertical * speed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(joystick.Horizontal * speed, rb.velocity.y, joystick.Vertical * speed);       
    }
}
