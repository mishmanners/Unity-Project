using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public ItemList sword;
    public ItemList hammer;
    public ItemList staff;

    // Start is called before the first frame update
    void Start()
    {
        sword = new ItemList("Sword", 1, "Vanquishing blade of the Dragonborn!");
        // sword.itemName = "Sword";
        // sword.id = 1;
        // sword.text = "Vanquishing blade of the Dragonborn!";

        hammer = new ItemList("Hammer", 2, "From the God of Thunder");

        staff = CreateItem("Staff", 3, "Lightning Staff of Restoration");

        // CreateItem("Staff", 3, "Lightning Staff of Restoration");
    }

    private ItemList CreateItem(string itemName, int id, string text)
    {
        var x = new ItemList(itemName, id, text);

        return x;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
