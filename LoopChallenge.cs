using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopChallenge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 30; i++)
        {
            if (i <= 10)
            {
                Debug.Log(i);
            }
            if (i > 10 && i <= 20 && i % 2 == 0)
            {
                Debug.Log(i);
            }
            if (i > 19 && i <= 30 && i % 2 == 1)
            {
                Debug.Log(i);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
