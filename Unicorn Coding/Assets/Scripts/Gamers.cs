using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamer
{
    public int id;
    public string gamertag;

    public static int connectionCount;

    public Gamer()
    {
        connectionCount++;
    }

}

public class Gamers: MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        Gamer p1 = new Gamer();
        Gamer p2 = new Gamer();
        Gamer p3 = new Gamer();
        Gamer p4 = new Gamer();
        Gamer p5 = new Gamer();
        Gamer p6 = new Gamer();
        Gamer p7 = new Gamer();
        Gamer p8 = new Gamer();

        Debug.Log("There are currently " + Gamer.connectionCount + " gamers playing Mario Kart");
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
