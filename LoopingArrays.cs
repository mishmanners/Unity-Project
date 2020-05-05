using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Items
{
    public int itemID;
    public string itemName;
    public string description;
}

public class LoopingArrays : MonoBehaviour
{
    
    public Items[] myItems;

    // Start is called before the first frame update
    public void Start()
    {
        /* printing out all items
       foreach (var item in myItems)
        {
            Debug.Log(item.itemName);
        }
        */

       /* if we wanted to use a foreach loop to check if variable exists
       foreach(var item in myItems)
       {
            if (item.itemID == 8)
            {
                Debug.Log("Yes this item exists!");
            }
            else
            {
                Debug.Log("Nope, no item exists. Go find it!");
            }
       
        }
        */ 

        // for loop to check if items exist or not
        for (int i = 0; i < myItems.Length; i++)
        {
            if ((myItems[i]).itemID == 8)
            {
                Debug.Log("Yes this item exists!");
            }
            else
            {
            Debug.Log("Nope, no item exists. Go find it!");   
            }
        }
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            int randomID = Random.Range(0, myItems.Length);

            // for (int i = 0; i < myItems.Length; i++) ;'
            Debug.Log(myItems[randomID].itemName);
            Debug.Log(myItems[randomID].description);
        }
    }
}
