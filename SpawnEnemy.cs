using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public static Transform target;

    public GameObject enemy;
    public GameObject boss;

    public GameObject[] spawnpos;

    private int randPosition;
    public float StartTimeBtwSpawns = 5f;
    public float StartTimeBtwSpawns2 = 35f;

    private float timeBtwSpawns;
    private float timeBtwSpawns2;

    public float StartTimeBtwSpawns3 = 1f;
    public float StartTimeBtwSpawns4 = 10f;

    private float timeBtwSpawns3;
    private float timeBtwSpawns4;

    public bool ExtraTime;
    void Start()
    {
        timeBtwSpawns = StartTimeBtwSpawns;
        timeBtwSpawns2 = StartTimeBtwSpawns2;
        timeBtwSpawns3 = StartTimeBtwSpawns3;
        timeBtwSpawns4 = StartTimeBtwSpawns4;
    }

    void FixedUpdate()
    {
        Invoke("ExtraTrue", 30f);

        if (ExtraTime == false)
        {
            StartSpawnTime();
        }

        if (ExtraTime == true)
        {
            StartSpawnTime2();
        }
    }

    private void StartSpawnTime()
    {
        if (timeBtwSpawns <= 0)
        {
            randPosition = Random.Range(0, spawnpos.Length);
            Instantiate(enemy, spawnpos[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns = StartTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }

        if (timeBtwSpawns2 <= 0)
        {
            randPosition = Random.Range(0, spawnpos.Length);
            Instantiate(boss, spawnpos[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns2 = StartTimeBtwSpawns2;
        }
        else
        {
            timeBtwSpawns2 -= Time.deltaTime;
        }
    }

    private void StartSpawnTime2()
    {
        if (timeBtwSpawns3 <= 0)
        {
            randPosition = Random.Range(0, spawnpos.Length);
            Instantiate(enemy, spawnpos[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns3 = StartTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns3 -= Time.deltaTime;
        }

        if (timeBtwSpawns4 <= 0)
        {
            randPosition = Random.Range(0, spawnpos.Length);
            Instantiate(boss, spawnpos[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns4 = StartTimeBtwSpawns2;
        }
        else
        {
            timeBtwSpawns4 -= Time.deltaTime;
        }
    }

    private void ExtraTrue()
    {
        ExtraTime = true;
    }
}
