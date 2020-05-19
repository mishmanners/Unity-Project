using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{
    public static void CreateObject()
    {
        //Create new primitive object (ie. cube)

        GameObject.CreatePrimitive(PrimitiveType.Cube);

    }

    public static void SetOrigPosition(GameObject obj)
    {
        //change the position of the object

        obj.transform.position = Vector3.zero;

    }
    


}
