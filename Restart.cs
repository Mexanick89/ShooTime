using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    public void Rest()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        EnemyScore.enemyscore = 0;
    }
}
