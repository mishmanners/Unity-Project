using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwesomePoints : MonoBehaviour
{
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            points = 50;
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            points = 100;
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            points = 0;
        }
        /*
        if (points == 50)
        {
            Debug.Log("You got lots of awesome points! Collect more to be as awesome as Mish");
        }

        else if (points == 100)
        {
            Debug.Log("MishManners got all the points! She da boooooooooooooom");
        }

        else
        {
            Debug.Log("Go find more points!");
        }
        */

        switch (points)
        {
            case 50:
                Debug.Log("You got lots of awesome points! Collect more to be as cool as Mish");
                break;
            case 100:
                Debug.Log("MishManners got all the points! She is da boooooooom");
                break;
            default:
                Debug.Log("Go find more points!");
                break;
        }

    
    }
}
