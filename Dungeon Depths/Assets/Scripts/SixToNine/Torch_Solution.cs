using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Torch_Solution : MonoBehaviour
{
    [SerializeField] GameObject cage;
    [SerializeField] GameObject hiddenText;
    [SerializeField] GameObject Text45;
    [SerializeField] GameObject Text90;
    public static List<GameObject> torchList = new List<GameObject>();
    public static List<GameObject> fullTorchList = new List<GameObject>();

    
    void Update()
    {
        /* This Section was for debugging this script. It is only commented out in case it is ever needed again.
         * Text txt = hiddenText.GetComponent<Text>();
         * txt.text = "Hidden Text: " + checkHidden();
         * txt = Text45.GetComponent<Text>();
         * txt.text = "Text 45: " + check45();
         * txt = Text90.GetComponent<Text>();
         * txt.text = "Text 90: " + check90();
        */
        if (checkHidden() && check45() && check90() && Torch_Movement.currentTorches == Torch_Movement.maxTorches){
            cage.SetActive(false);
        } else {
            cage.SetActive(true);
        }
    }

    // Checks if the torches with the Hidden Torch tag are all hidden
    private static bool checkHidden()
    {
        bool doneHidden = true;

        foreach(GameObject i in torchList) {
            if(i.tag == ("Hidden Torch") && i.activeSelf) {
                doneHidden = false;
                return doneHidden;
            } else if(i.tag == ("Hidden Torch") && !i.activeSelf) {
                doneHidden = true;
            }
        }

        return doneHidden;
    }

    // Checks if the torches with the Torch 45 tag are all at 45 or 135 degrees
    private static bool check45()
    {
        bool done45 = false;

        foreach (GameObject i in fullTorchList) {
            if (i.tag == ("Torch 45")) {
                if (i.transform.rotation == Quaternion.Euler(0, 0, -45)) {
                    done45 = true;
                } else if(i.transform.rotation == Quaternion.Euler(0, 0, 135)) {
                    done45 = true;
                } else {
                    done45 = false;
                    return done45;
                }
            }
        }

        return done45;
    }

    // Checks if the torches with the Torch 90 tag are all at 90 or -90 degrees
    private static bool check90()
    {
        bool done90 = false;

        foreach (GameObject i in fullTorchList) {
            if (i.tag == ("Torch 90")) {
                if (i.transform.rotation == Quaternion.Euler(0, 0, 90)) {
                    done90 = true;
                } else if (i.transform.rotation == Quaternion.Euler(0, 0, -90)) {
                    done90 = true;
                } else {
                    done90 = false;
                    return done90;
                }
            }
        }

        return done90;
    }
}
