using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch_Collision : MonoBehaviour
{
    // If the Player hits the fire of a fire spewer, it sends them back a level.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player")) {
            GameSysManager.LoadFloorPuzzle();
        }
    }
}
