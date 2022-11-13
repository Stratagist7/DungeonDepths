using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HD_FirePuzzle : HD_Trigger
{
    // Loads the Win World when the player runs into the trigger
    public override void OnTriggerEnter(Collider other)
    {
        GameSysManager.LoadWinWorld();
    }
}
