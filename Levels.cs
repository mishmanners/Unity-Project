using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public int Easy = 0;
    public int Medium = 1;
    public int Hard = 2;
    public int Default;

    // Start is called before the first frame update
    void Start()
    {
        Default = Medium;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Default == Easy)
        {
            Debug.Log("You're on easy mode");
        }
        else if (Default == Medium)
        {
            Debug.Log("You're on medium mode");
        }
        else if (Default == Hard)
        {
            Debug.Log("You're on hard mode... good luck!");
        }
        else
        {
            Debug.Log("You need to select a difficulty mode");
        }
    }
}
