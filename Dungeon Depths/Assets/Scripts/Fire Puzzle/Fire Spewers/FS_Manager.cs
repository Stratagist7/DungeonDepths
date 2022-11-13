using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FS_Manager : MonoBehaviour
{
    [SerializeField] private SO_FireSpewer SO;
    [SerializeField] private GameObject spewPrefab;
    private static float changeTime = 2.00f;
    private float timer;

    

    void Start()
    {
        timer += 0;
    }

    // If the fire spewere is not static, it moves every changeTime seconds to a random spot on the given axis between the Min and Max values.
    void Update()
    {
        if (!SO.isStatic) {
            timer += Time.deltaTime;
            if(timer >= changeTime) {
                timer = 0;
                float location = Random.Range(SO.Min, SO.Max);

                if (SO.xAxis) {
                    GameObject.Instantiate(spewPrefab, new Vector3(location, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                    Destroy(gameObject);
                } else if (SO.yAxis) {
                    GameObject.Instantiate(spewPrefab, new Vector3(gameObject.transform.position.x, location, gameObject.transform.position.z), gameObject.transform.rotation);
                    Destroy(gameObject);
                } else if (SO.zAxis) {
                    GameObject.Instantiate(spewPrefab, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, location), gameObject.transform.rotation);
                    Destroy(gameObject);
                } else
                    Debug.Log("A fire spewer is missing a bool variable");
            }
        }
    }
}
