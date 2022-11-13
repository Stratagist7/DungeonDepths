using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch_TorchList : MonoBehaviour
{
    // Adds the torch to the torchList
    private void Start()
    {
        Torch_Solution.torchList.Add(gameObject);
    }
}
