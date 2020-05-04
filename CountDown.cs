using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 100; i > 0; i--)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        Debug.Log("Okay, John... I'm done again!");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
