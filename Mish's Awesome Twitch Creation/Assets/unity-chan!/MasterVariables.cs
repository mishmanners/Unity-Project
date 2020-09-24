using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVariables : MonoBehaviour
{
    private string name = "Mish";
    private int age = 29;
    public int speed = 777;
    public int health = 9000;
    public float speedchange = 1f;
    public int score = 42;
    public bool keysCollected = false;
    public int amo = 37;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hey everyone, my name is " + name);
        Debug.Log("and I am " + age + " years old");
        Debug.Log("I can go really fast, because my speed is " + speed);
        Debug.Log("My power level is over " + health + "!");
        Debug.Log("Did I get the keys? Diana? Diana says " + keysCollected);
        Debug.Log("How much amo do I have left? " + amo);
        Debug.Log("My score is equal to " + score);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
