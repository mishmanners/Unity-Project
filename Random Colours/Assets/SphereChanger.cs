using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class SphereChanger
{
    // I am Australian, so it's RANDOMISE not RANDOMIZE!!!

    public static void RandomiseColour(GameObject obj)

    {
        obj.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);

    }

    public static void OnFire(GameObject fire, Transform location)
    {

        GameObject.Instantiate(fire, location.position, Quaternion.identity);

    }
    

}

