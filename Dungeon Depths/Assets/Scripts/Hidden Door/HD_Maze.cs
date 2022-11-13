using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HD_Maze : HD_Trigger
{
    // Loads the Rising Puzzle when the player runs into the trigger
    public override void OnTriggerEnter(Collider other)
    {
        GameSysManager.LoadRisingPuzzle();
    }
}
