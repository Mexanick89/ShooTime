using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewPlayer : MonoBehaviour
{
    public float dirX;
    public float dirY;
    public float sens;

    public Joystick joystick;

    public Transform Player;

    void FixedUpdate()
    {

        dirX = joystick.Horizontal * sens * Time.deltaTime;

        Player.Rotate(dirX * new Vector3(0, 1, 0));

        transform.Rotate(-dirY * new Vector3(1, 0, 0));
    }
}
