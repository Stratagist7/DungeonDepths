using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Text timerText;
    public static float startTime;
    public static float time;

    // Makes sure the timer is seen through each level.
    private void Awake()
    {
        DontDestroyOnLoad(canvas);
    }

    /* When the GameState is PLAYING, the timer counts up. 
     * When the GameState is MENU, the canvas is destroyed so there is no timer shown there.
     * When the GameState is WIN, the timer is stopped and is compared to the current Highscore. If the time is shorter, it replaces the Highscore.
     */
    private void Update()
    {
        if (GameSysManager.state == GameSysManager.GameState.PLAYING) {
            time = Time.time - startTime;

            string minutes = ((int)time / 60).ToString();
            string seconds = (time % 60).ToString("f2");

            if((time % 60) < 10)
                timerText.text = minutes + ":0" + seconds;
            else
                timerText.text = minutes + ":" + seconds;
        }
        if (GameSysManager.state == GameSysManager.GameState.MENU) {
            Destroy(canvas);
        }
        if (GameSysManager.state == GameSysManager.GameState.WIN) {
            if(time < PlayerPrefs.GetFloat("Highscore", 86400)) {
                PlayerPrefs.SetFloat("Highscore", time);
            }
        }
    }
}
