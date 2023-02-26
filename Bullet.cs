using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float life = 2;
    private void Awake()
    {
        Destroy(gameObject, life);
    }
}
