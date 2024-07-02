using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public static int deathScore;
    public Text ScoreText;
    public Text ScoreText1;
    void Start()
    {
        score = 0;
        deathScore = 0;
    }

    void Update()
    {
        ScoreText.text = score.ToString();
        ScoreText1.text = score.ToString();

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        

    }
}
