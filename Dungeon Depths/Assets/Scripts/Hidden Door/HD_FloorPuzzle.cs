using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HD_FloorPuzzle : HD_Trigger
{
    // Checks if the player has walked over every platform. If they have, they move on to the Six to Nine puzzle, otherwise, the scene is reloaded.
    public override void OnTriggerEnter(Collider other)
    {
        if (Platform_Collision.platformCount == Platform_Collision.totalPlatform) {
            GameSysManager.LoadSixToNine();

        } else {
            GameSysManager.LoadFloorPuzzle();

        }
    }
}
