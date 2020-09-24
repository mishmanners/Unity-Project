using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Items
{
    public string name;
    public int ID;
    public Sprite icon;

    public enum ItemType
    {
        Quest,
        Material,
        Consumable,
        Weapon,
        Armour,
        Miscellaneous
    }

    public ItemType itemType;

    public void Action()
    {
        switch(itemType)
        {
            case ItemType.Quest:
                Debug.Log("Quest Item. You can't sell this");
                break;

            case ItemType.Material:
                Debug.Log("Use this for crafting");
                break;

            case ItemType.Consumable:
                Debug.Log("Consume this item to learn it's effects");
                break;

            case ItemType.Weapon:
                Debug.Log("Used to attack things");
                break;

            case ItemType.Armour:
                Debug.Log("Use to protect things");
                break;

            case ItemType.Miscellaneous:
                Debug.Log("Other random things you picked up");
                break;

        }

    }
}

/* // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
