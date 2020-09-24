using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameArrays : MonoBehaviour
{
    /*
    public string name1 = "James";
    public string name2 = "OnePocketPimp";
    public string name3 = "dazed_nz";
    public string name4 = "skylarnight";
    public string name5 = "admiralasspounder";
    public string name6 = "JavaGrunt";
    public string name7 = "BurgZergArcarde";
    public string name8 = "Pandakaebi";
    public string name9 = "HackathonQueen";
    public string name10 = "crilanous";
    */

    public string[] names = new string[10];

    public string[] items = new string[7];

    public string[] weapons = new string[ ] { "sword", "bow", "shield", "twohanded", "staff" };

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Their name is " + names[Random.RandomRange(0,9)] + " with some " + items[Random.RandomRange(0, 6)] + " and a " + weapons[Random.RandomRange(0, 4)]);
        }

    }
}
