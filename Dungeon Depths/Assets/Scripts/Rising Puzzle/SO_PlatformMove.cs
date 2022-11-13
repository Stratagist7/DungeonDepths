using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Gets the start and end position and rotation for the platform movement
[CreateAssetMenu]
public class SO_PlatformMove : ScriptableObject
{
    [SerializeField] public Vector3 startPos = new Vector3();
    [SerializeField] public Vector3 startRot = new Vector3();

    [SerializeField] public Vector3 endPos = new Vector3();
    [SerializeField] public Vector3 endRot = new Vector3();
}
