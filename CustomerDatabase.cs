using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    public Customers Noctus;
    public Customers Gladious;
    public Customers Ignus;
    public Customers Prompto;

    // Start is called before the first frame update
    void Start()
    {
        Noctus = new Customers("Prince", "Noctus", 27, "male", "King of Regus");
        Gladious = new Customers("Sidekick", "Gladious", 32, "male", "Greatsword wielding Royal Guard");
        Ignus = new Customers("Sidekick", "Ignus", 33, "male", "Sharpshooter, Royal Guard");
        Prompto = new Customers("Sidekick", "Prompto", 25, "male", "Photographer");

    }

    /* private Customers CreateCustomer(string firstName, string lastName, int age, string gender, string occupation)
    {
        var x = new Customers(firstName, lastName, age, gender, occupation);

        return x;
    }
    */

    // Update is called once per frame
    void Update()
    {
        
    }
}
