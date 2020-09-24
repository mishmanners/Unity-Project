using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if space key is pressed --> print message
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space key");
        }
        // if e --> print
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Press E");
        }       
    }
}
