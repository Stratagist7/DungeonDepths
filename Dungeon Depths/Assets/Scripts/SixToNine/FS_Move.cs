using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FS_Move : MonoBehaviour
{
    [SerializeField] private GameObject objective;
    [SerializeField] private float lerpDuration;
    [SerializeField] private float waitTime;
    private Vector3 startLoc;

    // Sets the Fire Spewers' starting location and starts the moveFS coroutine
    private void Start()
    {
        startLoc = gameObject.transform.position;
        StartCoroutine(moveFS());
    }

    // Waits a couple seconds and then moves the Spewers' towards the player across the X axis over the course of lerpDuration.
    private IEnumerator moveFS()
    {
        yield return new WaitForSeconds(waitTime);
        float timeElapsed = 0;

        while (timeElapsed < lerpDuration) {

            transform.position = Vector3.Lerp(startLoc, new Vector3(objective.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), timeElapsed / lerpDuration);

            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }
}
