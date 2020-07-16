using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] SpawnStuff = new GameObject[3];
    public List<GameObject> SpawnedStuff = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int HowManyThingsSpawned = SpawnedStuff.Count;
        if (HowManyThingsSpawned < 10)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var SpawntheThings = SpawnStuff[Random.Range(0, SpawnStuff.Length)];
                var x = Random.Range(-10f, 10f);
                var y = Random.Range(-10f, 10f);
                GameObject NewObject = Instantiate(SpawntheThings, new Vector3(x, y, 0), Quaternion.identity);
                SpawnedStuff.Add(NewObject);         
            }
        }

        if (HowManyThingsSpawned == 10)
        {

            for (int i = 0; i < HowManyThingsSpawned; i++)
            {
                SpawnedStuff[i].GetComponent<MeshRenderer>().material.color = Color.green;

            }

            SpawnedStuff.Clear();
        }


    }
}
