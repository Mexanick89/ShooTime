using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBoss : MonoBehaviour
{
    Transform player;
    public float speed = 5;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        if (TeleportPos.teledele == true)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "death")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "ulta")
        {
            Destroy(gameObject);
        }
    }
}
