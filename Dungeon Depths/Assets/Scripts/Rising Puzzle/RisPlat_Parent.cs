using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisPlat_Parent : MonoBehaviour
{
    // Sets the player to be a child of the platform they are on.
    [SerializeField] GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player) {
            player.transform.parent = transform;
        }
    }

    // Removes the player as a child of the platform when they leave
    private void OnTriggerExit(Collider other)
    {
        player.transform.parent = null;
    }
}
