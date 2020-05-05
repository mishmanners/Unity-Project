using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public int health;
    public GameObject explosionEffect;

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        if (health < 1)
        {
            health = 0;
            Destroy(this.gameObject);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }


    }
        

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Damage(5);
        }
        
    }
}
