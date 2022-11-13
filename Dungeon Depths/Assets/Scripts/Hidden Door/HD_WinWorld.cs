using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HD_WinWorld : HD_Trigger
{
    // Quits to the menu when the player runs into the trigger
    public override void OnTriggerEnter(Collider other)
    {
        GameSysManager.QuitToMenu();
    }
}
