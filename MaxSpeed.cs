using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSpeed : MonoBehaviour
{
    public int speed;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 0;

        StartCoroutine(IncreaseSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }

    IEnumerator IncreaseSpeed()
    {
        for (int i = 0; i < Random.Range(60, 120); i++)
        {
            speed++;
            yield return new WaitForSeconds(1.0f);

        }
    }

}
