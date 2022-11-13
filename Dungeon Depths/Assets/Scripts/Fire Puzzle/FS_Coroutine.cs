using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FS_Coroutine : MonoBehaviour
{
    [SerializeField] private Transform start;
    [SerializeField] private Transform end;
    [SerializeField] private float waitTime;
    [SerializeField] private float phase;
    [SerializeField] private float speed;
    private int phaseDirection = 1;
    

    private void Update()
    {
            StartCoroutine(moveFire1());
    }

    //Lerps the fire spewer between two other spewer's location, gradually increasing speed, so run fast :)
    private IEnumerator moveFire1()
    {
        yield return new WaitForSeconds(waitTime);
        
            while (true) {
                transform.position = Vector3.Lerp(start.position, end.position, phase);

                phase += Time.deltaTime * speed * phaseDirection;

                if (phase >= 1 || phase <= 0) 
                    phaseDirection *= -1;

            yield return null;
            }

    }

}
