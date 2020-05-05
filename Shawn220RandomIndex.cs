using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shawn220RandomIndex : MonoBehaviour
{
    public GameObject Shawn; 
    private Vector3[] Positions = new Vector3[5];

    private int GetRandomIndex()
    {
         return Random.Range(0, 5);
    }



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Positions.Length; i++)
        {
            Positions[i] = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));

            // Shawns[i].transform.position = Positions[i];

            Shawn.transform.position = Positions[GetRandomIndex()];

        }


    }
    

    // Update is called once per frame
    void Update()
    {
        
    }


}
