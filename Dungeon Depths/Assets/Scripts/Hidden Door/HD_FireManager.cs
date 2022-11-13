using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HD_FireManager : MonoBehaviour
{
    [SerializeField] private GameObject[] doorways;
    [SerializeField] private GameObject[] fakeWalls;

    // Sets either the left or right side to be the exit, and blocks the opposite side.
    void Start()
    {
        int rng = Random.Range(0, doorways.Length);
        doorways[rng].SetActive(true);
        fakeWalls[rng].SetActive(true);
    }
    
}
