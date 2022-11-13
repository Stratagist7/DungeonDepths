using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HD_RisingPuzzle : HD_Trigger
{
    // Loads the Fire Puzzle when the player runs into the trigger
    public override void OnTriggerEnter(Collider other)
    {
        GameSysManager.LoadFirePuzzle();
    }
}
