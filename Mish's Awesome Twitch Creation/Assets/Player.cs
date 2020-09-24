using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startingpoint : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startPosition;
    void Start ()
    {
        // = (asign)
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
