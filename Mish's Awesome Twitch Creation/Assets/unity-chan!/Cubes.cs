using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* using for each loop
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach(var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            foreach (var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            foreach (var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.yellow;
            }
        }
        */
        // using for loop:
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (var i = 0; i < cubes.Length; i++)
            {
                cubes[i].GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }

    }
}
