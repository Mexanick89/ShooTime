using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    Image healthBar;
    public static float health = 100;
    public float MaxHealth = 100;

    public GameObject pauses;
    public GameObject menu;
    public GameObject ground;

    void Start()
    {
        health = MaxHealth;
        healthBar = GetComponent<Image>();
    }

    void FixedUpdate()
    {
        healthBar.fillAmount = health/MaxHealth;

        if (health <= 0)
        {
            menu.SetActive(true);
            ground.SetActive(false);
            pauses.SetActive(false);
            Invoke("Gameoff", 1f);
        }
    }

    private void Gameoff()
    {
        Time.timeScale = 0;
    }
}
