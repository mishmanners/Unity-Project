using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Items> itemDB = new List<Items>();

    void Start()
    {
        itemDB[0].Action();
        // itemDB[1].Action();
        // itemDB[2].Action();
        // itemDB[3].Action();
        // itemDB[4].Action();
        // itemDB[5].Action();


    }

}
