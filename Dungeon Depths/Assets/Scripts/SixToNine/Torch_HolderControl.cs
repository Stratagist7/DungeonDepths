using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch_HolderControl : MonoBehaviour
{
    [SerializeField] Material difMat;
    [SerializeField] Material ogMat;
    [SerializeField] GameObject torch;
    [SerializeField] GameObject buttons;
    [SerializeField] GameObject wholeTorch;
    [SerializeField] GameObject instructions;
    public static GameObject selectedWholeTorch;
    public static GameObject selectedHolder;
    public static GameObject selectedTorch;
    public static bool selected;
    public static Material staticMat;
    private Renderer ren;

    // Sets some variables
    private void Start()
    {
        selected = false;
        ren = gameObject.GetComponent<Renderer>();
    }

    // If nothing is selected, mousing over highlights the holder
    private void OnMouseEnter()
    {
        if (TMode_Trigger.torchMode) {
            if (!selected) {
                ren.material = difMat;
            }
        }
    }

    // If nothing is selected, the highlight disappears on exit of mouse
    private void OnMouseExit()
    {
        if (TMode_Trigger.torchMode) {

            if (!selected) {
                ren.material = ogMat;
            }

        }
    }

    // Sets the current holder as the selected torch on click. If the torch is already selected, it is deselected.
    private void OnMouseDown()
    {
        if (TMode_Trigger.torchMode) {
            if (!selected) {
                selected = true;
                selectedWholeTorch = wholeTorch;
                selectedHolder = gameObject;
                selectedTorch = torch;
                buttons.SetActive(true);
                instructions.SetActive(true);
                staticMat = ogMat;

            } else if (selected && gameObject == selectedHolder) {
                selected = false;
                buttons.SetActive(false);
                instructions.SetActive(false);
            }

        }
    }

    // Allows the material of the selected holder to return to it's original material in TMode_Trigger when exitting.
    public static void setOGMat()
    {
        selectedHolder.GetComponent<Renderer>().material = staticMat;
    }
}
