using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingPlat_Move : MonoBehaviour
{
    [SerializeField] private SO_PlatformMove SO;
    [SerializeField] private float lerpDuration;
    [SerializeField] private float waitTime;
    private bool up = true;

    // Starts the moveUp coroutine
    private void Start()
    {
        StartCoroutine(moveUp());
    }

    //Moves and rotates the platform to its upward location, and then calling the moveDown coroutine
    private IEnumerator moveUp()
    {
        float timeElapsed = 0;

        yield return new WaitForSeconds(waitTime);
        while (timeElapsed < lerpDuration) {
            
            transform.position = Vector3.Lerp(SO.startPos, SO.endPos, timeElapsed / lerpDuration);
            transform.rotation = Quaternion.Lerp(Quaternion.Euler(SO.startRot), Quaternion.Euler(SO.endRot), timeElapsed / lerpDuration);

            timeElapsed += Time.deltaTime;
            yield return null;
        }

        StartCoroutine(moveDown());
    }

    //Moves and rotates the platform to its downward location, and then calling the moveUp coroutine
    private IEnumerator moveDown()
    {
        float timeElapsed = 0;

        yield return new WaitForSeconds(waitTime);
        while (timeElapsed < lerpDuration) {
            transform.position = Vector3.Lerp(SO.endPos, SO.startPos, timeElapsed / lerpDuration);
            transform.rotation = Quaternion.Lerp(Quaternion.Euler(SO.endRot), Quaternion.Euler(SO.startRot), timeElapsed / lerpDuration);

            timeElapsed += Time.deltaTime;
            yield return null;
        }

        StartCoroutine(moveUp());
    }
}
