using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch_Movement : MonoBehaviour
{
    private GameObject torch;
    private GameObject selectedHolder;
    public static int maxTorches = 5;
    public static int currentTorches = 0;

    // Checks and sets the selected torch and parts to the appropriate variables
    private void Update()
    {
        if (Torch_HolderControl.selectedWholeTorch != null) {
            selectedHolder = Torch_HolderControl.selectedWholeTorch;
            torch = Torch_HolderControl.selectedTorch;
        }
    }

    // Activates/Deactivates the selected torch
    public void setActiveTorch()
    {
        if (currentTorches < maxTorches && !torch.activeSelf) {
            torch.SetActive(true);
            currentTorches++;
        } else if (torch.activeSelf) {
            torch.SetActive(false);
            currentTorches--;
        }
    }

    // Turns the selected torch clockwise 45 degrees
    public void turnClockwise()
    {
        if(torch.activeSelf)
            selectedHolder.transform.rotation *= Quaternion.Euler(0, 0, 45);
    }

    // Turns the selected torch counter clockwise 45 degrees
    public void turnCounterClockwise()
    {
        if (torch.activeSelf)
            selectedHolder.transform.rotation *= Quaternion.Euler(0, 0, -45);
    }

}
