using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock_Sound : MonoBehaviour
{
    [SerializeField] private GameObject cage;
    [SerializeField] private AudioSource sound;

    // When the cage unlocks, it plays a sound to alert the player
    private void Update()
    {
        if (cage.activeSelf)
            sound.Play();
    }
}
