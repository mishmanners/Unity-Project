using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Pet
{
    protected override void Speak()
    {
        Debug.Log("Meow");
    }
}
