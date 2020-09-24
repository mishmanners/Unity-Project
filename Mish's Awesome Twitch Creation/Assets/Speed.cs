using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            speed += 1;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            speed -= 1;

        }

        if (speed > 20)
        {
            Debug.Log("You need to slow down");
        }
        else if (speed == 0)
        {
            Debug.Log("You need to speed up");
        }

        if (speed <= 0)
        {
            speed = 0;
        }

    }
}
