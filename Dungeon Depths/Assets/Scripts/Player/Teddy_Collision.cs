using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teddy_Collision : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        // If the player walks over teddy, left clicks, and does not already have a teddy, gives the player a teddy and disables this one
        if (other.gameObject.name.Equals("Player")) {
            if (Input.GetMouseButtonDown(0) && !C_Interact.isTeddyThere) {
                C_Interact.isTeddyThere = true;
                Destroy(gameObject);
            }
        }
    }
}
