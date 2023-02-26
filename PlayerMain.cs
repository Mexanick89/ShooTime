using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    [SerializeField] AudioSource voiceplayerah;
    public GameObject blood;
    public bool activ;

    private void FixedUpdate()
    {
        if(PowerPlayer.power == 0)
        {
            activ = false;
        }
        
        if(PowerPlayer.power >= 15)
        {
            activ = true;
        }       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            voiceplayerah.Play();
            blood.SetActive(true);
            HealthPlayer.health -= 15;
            Invoke("Boff", 0.5f);
        }

        if (other.gameObject.tag == "bossbullet")
        {
            if (activ == true)
            {
                PowerPlayer.power -= 15;
            }
        }
    }

    private void Boff()
    {
        blood.SetActive(false);
    }
}
