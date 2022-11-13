using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Platform_Collision : MonoBehaviour
{
    public const int totalPlatform = 31;
    public static int platformCount = 0;
    [SerializeField] private GameObject platform;
    [SerializeField] private AudioSource motionSound;


    // If the player walks over an enabled platform, it disables it and increases platformCount by 1, otherwise it resets the scene
    private void OnTriggerEnter(Collider other)
    {
        if (platform.activeSelf) {
            if (other.gameObject.name.Equals("Player")) {
                platform.SetActive(false);
                motionSound.Play();
                platformCount++;
                //Debug.Log(platformCount);
            }
        } else if(!platform.activeSelf && other.gameObject.name.Equals("Player")) {
            GameSysManager.LoadFloorPuzzle();
            
        }
    }
}
