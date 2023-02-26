using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPos : MonoBehaviour
{
    public Transform poinTeleport;

    public static bool teledele;

    private void OnTriggerStay(Collider other)
    {
        teledele = true;
        other.transform.position = poinTeleport.transform.position;
        teledele = true;
        Invoke ("Tel", 0.1f);
    }

    private void Tel()
    {
        teledele = false;
    }
}
