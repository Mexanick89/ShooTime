using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniEnemy : MonoBehaviour
{
    public static float health = 50;
    public float speed = 3;

    public GameObject reco;

    Transform player;

    private bool roof;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if (roof == false)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (roof == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "roof")
        {
            roof = true;
        }

        if (other.gameObject.tag == "death")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "bullet")
        {
            PowerPlayer.power += 15;
            EnemyScore.enemyscore += 1;
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "bullet")
        {
            if (HealthPlayer.health >= 15)
            {
                reco.SetActive(true);
            }
        
        }

        if (other.gameObject.tag == "ulta")
        {
            EnemyScore.enemyscore += 1;
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "recosh")
        {
            if (HealthPlayer.health >= 15)
            {
                Imitatioin();
            }
        }
    }

    public void Imitatioin()
    {
        Invoke("TrueImitation", 0.7f);
    }

    public void TrueImitation()
    {
        EnemyScore.enemyscore += 1;
        Destroy(gameObject);
        HealthPlayer.health += 25;
    }
}
