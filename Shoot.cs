using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] AudioSource soundshoot;
    public Transform bulletSpawnPoint;
    public GameObject BulletPrefab;
    public float bulletSpeed = 10;
    public void PreShoot()
    {
        soundshoot.Play();
        var bullet = Instantiate(BulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    }
}
