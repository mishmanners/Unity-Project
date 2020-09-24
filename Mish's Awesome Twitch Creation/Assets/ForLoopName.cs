using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopName : MonoBehaviour
{
    public string Myname = "the program";

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log(Myname);

        }

        Debug.Log("Okay John... I am now finished...");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
