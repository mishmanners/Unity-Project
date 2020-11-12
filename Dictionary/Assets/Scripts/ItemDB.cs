using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();


    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    private void Start()
    {
        // itemList.Add(sword);

        Item sword = new Item { name = "Crimson Sword", id = 0 };
        Item staff = new Item { name = "Crimson Frost Staff", id = 1 };
        Item shield = new Item { name = "Crimson Shield", id = 2 };
        Item chest = new Item { name = "Crimson Cuirass", id = 3 };
        Item arms = new Item { name = "Crimson Guantlets", id = 4 };
        Item boots = new Item { name = "Crimson Boots", id = 5 };
        Item legs = new Item { name = "Crimson Greaves", id = 6 };
        Item belt = new Item { name = "Crimson Belt", id = 7 };

        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, staff);
        itemDictionary.Add(2, shield);
        itemDictionary.Add(3, chest);
        itemDictionary.Add(4, arms);
        itemDictionary.Add(5, boots);
        itemDictionary.Add(6, legs);
        itemDictionary.Add(7, belt);


        /* foreach (KeyValuePair<int, Item> item in itemDictionary)
        {
            Debug.Log("Key: " + item.Key);
            Debug.Log("Value: " + item.Value.name);
        }*/

        foreach(var item in itemDictionary)
        {
            Debug.Log("Name: " + item.Value.name);
       
        }

        Debug.Log("fish");
    }


}
