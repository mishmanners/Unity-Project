using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    [SerializeField] GameObject[] TheObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
        TheObjects[0].transform.position = Vector3.MoveTowards(TheObjects[0].transform.position, TheObjects[1].transform.position, 5f * Time.deltaTime);
        TheObjects[1].transform.position = Vector3.MoveTowards(TheObjects[1].transform.position, TheObjects[2].transform.position, 5f * Time.deltaTime);
        TheObjects[2].transform.position = Vector3.MoveTowards(TheObjects[2].transform.position, TheObjects[3].transform.position, 5f * Time.deltaTime);
        TheObjects[3].transform.position = Vector3.MoveTowards(TheObjects[3].transform.position, TheObjects[4].transform.position, 5f * Time.deltaTime);
        TheObjects[4].transform.position = Vector3.MoveTowards(TheObjects[4].transform.position, TheObjects[0].transform.position, 5f * Time.deltaTime);
    }
    
}
