using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public float points;

    public bool HasSaidMessage = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y)) 
        {
            points = points + 10;
        }

        if ((points > 9000) && (HasSaidMessage == false))
        {
            Debug.Log("His power level's over 9000!");
            HasSaidMessage = true;
        }

    }
}
