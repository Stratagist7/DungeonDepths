using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squeak : MonoBehaviour
{
    [SerializeField] private AudioSource theSqueak;

    // Plays the amazing Squeak :)
    void Start()
    {
        theSqueak.Play();
    }
}
