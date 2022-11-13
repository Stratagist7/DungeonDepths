using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tracks variables for teleporting the fire spewers
[CreateAssetMenu]
public class SO_FireSpewer : ScriptableObject
{
    [SerializeField] public bool isStatic;
    [SerializeField] public float Min;
    [SerializeField] public float Max;
    [SerializeField] public bool xAxis;
    [SerializeField] public bool yAxis;
    [SerializeField] public bool zAxis;
}
