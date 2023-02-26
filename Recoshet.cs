using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoshet : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject BulletPrefab;
    public float bulletSpeed = 10;

    public static bool rec;

    Transform enemy;

    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("enemy").transform;
    }

    private void Update()
    {
        if (rec == true)
        {
            Recosh();
        }
    }

    public void Recosh()
    {
        var bullet = Instantiate(BulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = Vector3.MoveTowards(transform.position, enemy.position, bulletSpeed * Time.deltaTime);
    }
}
