using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame_Collision : MonoBehaviour
{
    // If the Player hits the fire of a fire spewer, it resets the level.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player")) {
            GameSysManager.LoadFirePuzzle();
        }
    }
}
