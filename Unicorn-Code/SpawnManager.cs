using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float timer = 3f;
    public static int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            timer = 3f;
            Instantiate(enemyPrefab, transform.position + new Vector3(Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity);
        }

    }
}
