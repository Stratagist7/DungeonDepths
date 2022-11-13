using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class HD_Trigger : MonoBehaviour
{

    // The abstract method for each of the Hidden Door scripts
    public abstract void OnTriggerEnter(Collider other);

}
