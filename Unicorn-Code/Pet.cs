using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    protected string petName;
    protected string species;

    protected virtual void Speak()
    {
        Debug.Log("Say hi!");
    }

    private void Start()
    {
        Speak();
    }

}
