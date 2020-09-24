using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Spell
{
    public string name;
    public int levelRequired;
    public int itemIDrequired;
    public int expGained;

    public Spell(string name, int levelRequired, int itemIDrequired, int expGained)
    {
        this.name = name;
        this.levelRequired = levelRequired;
        this.itemIDrequired = itemIDrequired;
        this.expGained = expGained;

    }

    public void Cast()
    {
        Debug.Log("Cast the spell");
    }
}
