using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    public string itemName;
    public int itemID;

    public static int itemCount;

    public Items()
    {
        itemCount++;
    }

}

public class Test : MonoBehaviour
{     
    // Start is called before the first frame update
    public void Start()

    {

        Items sword = new Items();
        Items bakedApples = new Items();
        Items staticPoision = new Items();
        Items dragonBow = new Items();

        Debug.Log("Item Count: " + Items.itemCount);


    }

    // Update is called once per frame
    public void Update()

    {
        
    }
}
