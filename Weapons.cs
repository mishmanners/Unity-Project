using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public int WeaponID;
    public int Kingsman = 1;
    public int DeadpoolsGuns = 2;
    public int MachineGun = 3;
    public int Shotgun = 4;
    public int HeavySniper = 5;


    // Start is called before the first frame update
    void Start()
    {

        WeaponID = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            WeaponID = Random.Range(1, 6);

        switch (WeaponID)
        {
        case 1:
            Debug.Log("Bring out the Kingsman!");
            break;
        case 2:
            Debug.Log("Make your foes jealous with Deadpool's Guns");
            break;
        case 3:
            Debug.Log("Take down your enemies with this mini");
            break;
        case 4:
            Debug.Log("Do lots of damage with this shotgun");
            break;
        case 5:
            Debug.Log("Yay, it's my favourite weapon!");
            break;
        default:
            Debug.Log("Please select a weapon");
            break;


        }
        
    }
}
