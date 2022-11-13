using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Interact : MonoBehaviour
{
    public static bool isTeddyThere;
    [SerializeField] private ParticleSystem torchLight;
    [SerializeField] private ParticleSystem torchFire;
    [SerializeField] private new GameObject light;
    
    [SerializeField] private GameObject teddy;
    [SerializeField] private GameObject teddyPrefab;
    [SerializeField] private AudioSource squeak;


    void Update()
    {
        // If teddy is there but not enabled, enables teddy
        if (isTeddyThere && !teddy.activeSelf) {
            teddy.SetActive(true);
            squeak.Play();
        } 

        // If teddy has been dropped, disables him on the Player
        if(!isTeddyThere){
            teddy.SetActive(false);
        }

        // M1 turns on and off the torch in hand
        if (Input.GetMouseButtonDown(0)) {
            light.SetActive(!light.activeSelf);
            var emission = torchFire.emission;
            emission.enabled = !emission.enabled;
            emission = torchLight.emission;
            emission.enabled = !emission.enabled;

        }

        // If teddy is there and you right click, teddy will drop from your hand and fall to the ground
        if (isTeddyThere && Input.GetMouseButton(1)) {
            Instantiate(teddyPrefab, new Vector3(teddy.transform.position.x, teddy.transform.position.y, teddy.transform.position.z), new Quaternion(0, 0, 0, 0));
            isTeddyThere = false;
        }
    }
}
