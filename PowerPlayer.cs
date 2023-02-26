using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PowerPlayer : MonoBehaviour
{
    Image powerBar;
    public static float power;
    public float MaxPower = 100;
    public float HalfPower = 50;
    public float MinPower = 0;

    public GameObject ButtonUlta;

    void Start()
    {
        power = HalfPower;
        powerBar = GetComponent<Image>();
    }

    void FixedUpdate()
    {
        powerBar.fillAmount = power/MaxPower;

        if(power >= 99)
        {
            ButtonUlta.SetActive(true);
        }

        if(power <= 99)
        {
            ButtonUlta.SetActive(false);
        }
    }


}
