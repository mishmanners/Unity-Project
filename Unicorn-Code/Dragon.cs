using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Pet
{
    public GameObject fire;

    protected override void Speak()
    {
        Debug.Log("Roar");
        Instantiate(fire, transform.position + new Vector3(3, 1, 0), Quaternion.identity);
    }
}
