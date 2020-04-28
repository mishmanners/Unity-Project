using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string name = "Avocardo";
    public string description = "best food ever, costs lots of money, millenials buy them instead of houses";
    public Sprite sprite;
    public float attackStrength = 9;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = new GameObject("Avocardo");
        SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = sprite;
    }

}