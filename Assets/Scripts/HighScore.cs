using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TMP_Text HighScoreText;
    void Start()
    {
        HighScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

}
