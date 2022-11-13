using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HD_SixToNine : HD_Trigger
{
    // Loads the Maze when the player runs into the trigger
    public override void OnTriggerEnter(Collider other)
    {
        GameSysManager.LoadMaze();
    }
}
