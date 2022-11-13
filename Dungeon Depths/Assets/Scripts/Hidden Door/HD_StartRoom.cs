using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HD_StartRoom : HD_Trigger
{
    [SerializeField] GameObject instructions;

    // Loads the Floor Puzzle, sets the start time for the timer, and shows the camera cut scene in Floor Puzzle.
    public override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player")) {
            GameSysManager.LoadFloorPuzzle();
            instructions.SetActive(false);
            Timer.startTime = Time.time;
            Camera_ShutDown.showCam = true;
        }
    }


}
