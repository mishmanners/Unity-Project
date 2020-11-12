using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string name;
    public int id;

    public Player(int id)
    {
        this.id = id;
    }

}

public class Main : MonoBehaviour

{

    // Start is called before the first frame update

    public Dictionary<int, Player> playerDictionary = new Dictionary<int, Player>();
    private void Start()
    {
        Player P1 = new Player(7);
        P1.name = "Mish";
        Player P2 = new Player(200);
        P2.name = "Mr Richard";
        Player P3 = new Player(9000);
        P3.name = "Techieman";
        Player P4 = new Player(46312);
        P4.name = "Aaron";

        playerDictionary.Add(P1.id, P1);
        playerDictionary.Add(P2.id, P2);
        playerDictionary.Add(P3.id, P3);
        playerDictionary.Add(P4.id, P4);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var player = playerDictionary[200];
            Debug.Log("Player name: " + player.name);
        }
    }
}
