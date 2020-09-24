using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingCube : MonoBehaviour
{
    public GameObject cube;
    public int score;
    
    // Start is called before the first frame update
    void Start()
    {

    cube.GetComponent<Renderer>().material.color = Color.red;

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
            
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            cube.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            cube.GetComponent<Renderer>().material.color = Color.red;
        }
        if (score > 50)
        {
            cube.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
