using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apples : MonoBehaviour
{
    public int apples;

    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(AddApples());

        do
        {
            apples++;
        } while (apples < 5);

        Debug.Log("how do you like them apples");
         
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*

    IEnumerator AddApples()
    {
        for (int i = 0; i < 100; i++)
        {
            apples++;
            yield return new WaitForSeconds(0.5f);        }
    }
    */

}
