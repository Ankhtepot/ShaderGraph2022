using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i;
        for (i = 0; i < 65; i++)
        {
            if (i == 70) break;
        }
        
        Debug.Log($"Loop result: {i}");
    }
}
