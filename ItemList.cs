using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class ItemList
{
    public string itemName;
    public int id;
    public string text;
    public Sprite icon;

    public ItemList(string itemName, int id, string text)
    {
        this.itemName = itemName;
        this.id = id;
        this.text = text;

    }
}
