using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{

    public enum LevelSelector
    {
        Easy = 0, //asigned to binary numbers
        Normal = 5,
        Hard = 42,
        Expert = 23
    }

    public LevelSelector currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        if (currentLevel == LevelSelector.Easy)
        {
            Debug.Log("You're on the easiest difficulty setting. Maybe try harder!");
        }

        if (currentLevel == LevelSelector.Normal)
        {
            Debug.Log("You're on the average difficulty setting");
        }

        if (currentLevel == LevelSelector.Hard)
        {
            Debug.Log("Good job, you're on the hard setting");
        }

        if (currentLevel == LevelSelector.Expert)
        {
            Debug.Log("Can't get any tougher than this! Go you!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
