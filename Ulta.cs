using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ulta : MonoBehaviour
{
    [SerializeField] AudioSource ultaon;
    public GameObject ulta;

    private void Update()
    {
        if (ulta == true)
        {
            ultaon.Play();
        }
    }

    public void TrueUlta()
    {
        ulta.SetActive(true);
        PowerPlayer.power = 0;
        Invoke(nameof(UltaOff), 0.5f);
    }

    private void UltaOff()
    {
        ulta.SetActive(false);
    }
}
