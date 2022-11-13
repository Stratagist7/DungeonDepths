using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HS_Text : MonoBehaviour
{
    [SerializeField] TextMesh hsText;
    private float highScore;

    // Gets the Highscore player pref and sets it in the form of minutes and seconds.
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("Highscore", 00.00f);
        string minutes = ((int)highScore / 60).ToString();
        string seconds = (highScore % 60).ToString("f2");

        if ((highScore % 60) < 10)
            hsText.text = "High Score:\n" + minutes + ":0" + seconds;
        else
            hsText.text = "High Score:\n" + minutes + ":" + seconds;
    }
}
