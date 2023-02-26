using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScore : MonoBehaviour
{
    public static int enemyscore = 0;
    Text Textenemy;
    public Text highscore;

    private void Start()
    {
        Textenemy = GetComponent<Text>();
        highscore.text = PlayerPrefs.GetInt("best", 0).ToString();
    }

    private void Update()
    {
        Textenemy.text = enemyscore.ToString();

        if(enemyscore > PlayerPrefs.GetInt("best", 0))
        {
            PlayerPrefs.SetInt("best", enemyscore);
            highscore.text = enemyscore.ToString();
        }
    }

}
