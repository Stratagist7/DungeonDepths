using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TMode_Trigger : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject cam;
    [SerializeField] GameObject player;
    [SerializeField] GameObject button;
    [SerializeField] GameObject buttonList;
    [SerializeField] GameObject instructions;
    [SerializeField] GameObject FS;
    public static bool torchMode = false;

    // When clicking the exit button, reactivates and focuses on the Player's camera and cursor. Deactivates any UI for torchmode.
    public void exitButton()
    {
        cam.SetActive(false);
        button.SetActive(false);
        text.SetActive(true);
        player.SetActive(true);
        buttonList.SetActive(false);
        instructions.SetActive(false);
        torchMode = false;

        if (Torch_HolderControl.selected) {
            Torch_HolderControl.setOGMat();
            Torch_HolderControl.selected = false;
        }

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Shows the text instructions for entering Torch Mode
    private void OnTriggerEnter(Collider other)
    {
        text.SetActive(true);
    }

    // Pressing F enters the Player into Torch Mode, changes the camera view to focus on the torches and hide the player, unlocks any cursor limits.
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F) || Input.GetKey(KeyCode.F)) {
            cam.SetActive(true);
            button.SetActive(true);
            text.SetActive(false);
            player.SetActive(false);
            FS.SetActive(true);
            torchMode = true;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }

    // Hides the text instructions for entering Torch Mode
    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }
}
