using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_ShutDown : MonoBehaviour
{
    public static bool showCam = true;
    [SerializeField] private float timer = 0;
    private const float maxTime = 6.00f;
    


    // Turns off the camera after maxTime
    void Update()
    {
        if(showCam) {
            timer += Time.deltaTime;

            if (timer >= maxTime || Input.GetKeyDown(KeyCode.Escape))
                gameObject.SetActive(false);
        } else {
            gameObject.SetActive(false);
        }
    }
}
