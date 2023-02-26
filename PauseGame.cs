using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PauseGame : MonoBehaviour
{
    [SerializeField] GameObject pause;
    public void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseOff()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
}
