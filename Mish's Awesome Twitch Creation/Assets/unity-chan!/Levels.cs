using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public int Easy = 0;
    public int Medium = 1;
    public int Hard = 2;
    public int LevelSelect;

    // Start is called before the first frame update
    void Start()
    {
        LevelSelect = Medium;
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (LevelSelect == Easy)
        {
            Debug.Log("You're on easy mode");
        }
        else if (LevelSelect == Medium)
        {
            Debug.Log("You're on medium mode");
        }
        else if (LevelSelect == Hard)
        {
            Debug.Log("You're on hard mode... good luck!");
        }
        else
        { }
            Debug.Log("You need to select a difficulty mode");
        }
        */

        switch (LevelSelect)
        {
            case 0:
                Debug.Log("You're on easy mode");
                break;
            case 1:
                Debug.Log("You're on medium mode");
                break;
            case 2:
                Debug.Log("You're on hard mode. Good Luck!");
                break;
            default:
                Debug.Log("You need to select a difficulty mode");
                break;
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            LevelSelect = Random.Range(0, 3);
        }

        
    }
}
