using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadorAlive : MonoBehaviour
{
    public int health;
    public GameObject explosionEffect;
    public bool deadAlive = false;

    public void Damage(int damageAmount)

    {
        health -= damageAmount;

        if (health < 1)
        {
            health = 0;
            Destroy(this.gameObject);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            
            if (!deadAlive)
            {
                Debug.Log("You are dead! GAME OVER");
                deadAlive = true;
            }
            
        }
     }


    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Damage(Random.Range(0, 10));

        }
        
    }
}
