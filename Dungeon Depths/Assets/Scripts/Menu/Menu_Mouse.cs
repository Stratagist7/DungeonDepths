using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Mouse : MonoBehaviour
{
    [SerializeField] private GameObject outline;
    [SerializeField] private AudioSource hoverSound;
    [SerializeField] private AudioSource clickSound;


    // Hovering over the object shows the outline and plays the hover sound
    public void OnMouseEnter()
    {
        outline.SetActive(true);
        hoverSound.Play();
    }

    // Leaving the object with your mouse hides the outline
    public void OnMouseExit()
    {
        outline.SetActive(false);
    }

    // If the mouse clicks on the Start button, it loads the Start Room
    public void OnMouseDown()
    {
        clickSound.Play();
        if(gameObject.name.Equals("Start Detection")) {
            GameSysManager.NewGame();
        }
        if(gameObject.name.Equals("Quit Detection")) {
            Application.Quit();
        }
        if (gameObject.name.Equals("Best Detection")) {
            GameSysManager.LoadBestTime();
        }
        if (gameObject.name.Equals("Menu Detection")) {
            GameSysManager.QuitToMenu();
        }
    }
}

