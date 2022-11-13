using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch_FullList : MonoBehaviour
{
    // Adds the full torch to the fullTorchList
    private void Start()
    {
        Torch_Solution.fullTorchList.Add(gameObject);
    }
}
