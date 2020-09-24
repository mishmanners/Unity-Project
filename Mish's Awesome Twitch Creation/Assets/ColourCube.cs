using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourCube : MonoBehaviour
{
    public GameObject cube;
    public int score;
    
    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
            score += 10;
        if (Input.GetKeyDown(KeyCode.P))
            score -= 10;

        if (score <= 0)
            score = 0;

        switch (score)
        {
            case 0:
                cube.GetComponent<Renderer>().material.color = Color.gray;
                break;
            case 20:
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 40:
                cube.GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 60:
                cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 80:
                cube.GetComponent<Renderer>().material.color = Color.magenta;
                break;
            case 100:
                cube.GetComponent<Renderer>().material.color = Color.cyan;
                break;
        }
        
    }
}
