using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int target;
    public int MaxtTarget = 2;
    public float speed = 1;

    Transform player;

    public float StartTimeBtwSpawns = 5f;
    public GameObject enemy;
    public GameObject spawnpos;
    private float timeBtwSpawns;

    private void Start()
    {
        target = MaxtTarget;
        timeBtwSpawns = StartTimeBtwSpawns;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if (timeBtwSpawns <= 0)
        {
            Instantiate(enemy, spawnpos.transform.position, Quaternion.identity);
            timeBtwSpawns = StartTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }

        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        if (target == 0)
        {
            EnemyScore.enemyscore += 1;
            PowerPlayer.power += 50;
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.tag == "death")
            {
                Destroy(gameObject);
            }

            if (other.gameObject.tag == "bullet")
            {

            target -= 1;
            Destroy(other.gameObject);
            }

            if (other.gameObject.tag == "ulta")
            {
            EnemyScore.enemyscore += 1;
            Destroy(gameObject);
            }
    }
}
