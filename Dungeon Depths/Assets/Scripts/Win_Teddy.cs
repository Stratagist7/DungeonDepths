using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Teddy : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject teddy;
    [SerializeField] private Material teddyMat;
    [SerializeField] private List<GameObject> teddyList = new List<GameObject>();
    [SerializeField] private GameObject fireworks;
    [SerializeField] private AudioSource fireworkSound;
    private Renderer ren;

    // Sets the renderer of teddy.
    private void Awake()
    {
        ren = teddy.GetComponent<Renderer>();
    }

    // If the player is in range and has teddy, it will show the instructions text.
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && C_Interact.isTeddyThere == true) {
            text.SetActive(true);
        }
    }

    // Hides the instructions text when the player leaves the range.
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player") {
            text.SetActive(false);
        }
    }

    // If the player has teddy and they press F, teddy's material is changed, the player's teddy is removed, and the easterEgg coroutine begins.
    private void OnTriggerStay(Collider other)
    {
        if(C_Interact.isTeddyThere == true && (Input.GetKeyDown(KeyCode.F) || Input.GetKey(KeyCode.F))) {
            ren.material = teddyMat;
            text.SetActive(false);
            C_Interact.isTeddyThere = false;

            StartCoroutine(easterEgg());
        }
    }

    // Shows a teddy, waits a second, repeat. Once all teddies are shown, the firework particles and sounds begin.
    private IEnumerator easterEgg()
    {
        yield return new WaitForSeconds(1);
        foreach(GameObject obj in teddyList) {
            obj.SetActive(true);
            yield return new WaitForSeconds(1);
        }
        fireworks.SetActive(true);
        fireworkSound.Play();
    }
}
