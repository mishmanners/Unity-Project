using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // public Dictionary<string, int> guilds = new Dictionary<string, int>();

    public Dictionary<int, string> viewers = new Dictionary<int, string>();

    // Start is called before the first frame update
    private void Start()
    {
        /* guilds.Add("Moocats", 9);
        guilds.Add("The Lost Dwemer", 3);
        guilds.Add("Mind your Manners", 1);
        guilds.Add("Treasure Hunters", 7);

        int guildNumber = guilds["Moocats"];

        Debug.Log("Moocats are guild number: " + guildNumber);
        */

        viewers.Add(0, "pylang");
        viewers.Add(1, "HackathonQueen");
        viewers.Add(2, "OMGoddyr");
        viewers.Add(3, "smash8tap");
        viewers.Add(4, "zqwertyuiop1");
        viewers.Add(5, "Raventhorn");

        Debug.Log(viewers[5] + " worked on the .NET Framework 1.0 team. And came and saw me last week at the .NET Conf Day 3 Live Stream.");

        // manipulating Keys and Values
        foreach (KeyValuePair<int, string> viewer in viewers)
        {
            Debug.Log("Viewer: " + viewer.Value + ". Thank you so much for joining the stream!");
            Debug.Log("Viewer Number: " + viewer.Key);
        }
        // accesses just the Value
        foreach (string viewer in viewers.Values)
        {
            Debug.Log("Viewer: " + viewer + " . Yay you got thanked twice!");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
