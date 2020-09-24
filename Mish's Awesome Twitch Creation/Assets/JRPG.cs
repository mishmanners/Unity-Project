using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JRPG : MonoBehaviour
{
    public int[] itemID = new int[5];
    public string[] itemName = new string[5];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < itemName.Length; i++)
            {
                /* if (itemID[i] == 4)
                {
                    Debug.Log(itemName[4]);
                }

                if(itemName[i] == "Apples")
                {
                    Debug.Log("Yes Apples exists!");
                    Debug.Log(itemID[i]);
                }
                */
                foreach (var item in itemName)
                {
                    // Debug.Log(item);
                    if (item == "Unicorn")
                    {
                        Debug.Log(item);
                    }


                }
            }
        }
        
    }
}
